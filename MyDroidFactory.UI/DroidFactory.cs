using MyDroidFactory.Business;
using MyDroidFactory.Business.Enums;

namespace MyDroidFactory.UI;

public partial class DroidFactory : Form
{
    private List<Droid> _listOfDroids = new List<Droid>();
    private Droid _droid;
    private int _dictionaryIndex;
    private bool _isUpdating = false;
    public BoolCarrier DroidFactoryBoolCarrier;

    public void resetFields()
    {
        cbTypeOfDroid.SelectedIndex = 0;
        cbEquipment1.SelectedIndex = 0;
        cbEquipment2.SelectedIndex = 0;
        cbEquipment3.SelectedIndex = 0;
        cbEquipment4.SelectedIndex = 0;
        cbEquipment5.SelectedIndex = 0;
        cbEquipment6.SelectedIndex = 0;
        cbArmament1.SelectedIndex = 0;
        cbArmament2.SelectedIndex = 0;
        cbArmament3.SelectedIndex = 0;
        cbArmament4.SelectedIndex = 0;
        cbArmament5.SelectedIndex = 0;
        cbArmament6.SelectedIndex = 0;
        cbPlating.SelectedIndex = 0;
        cbAiChip.SelectedIndex = 0;
        txtId.Clear();
        txtModel.Clear();
        txtManufacturer.Clear();
        txtHeight.Clear();
        txtMass.Clear();
    }

    public DroidFactory(List<Droid> listOfDroids, BoolCarrier boolCarrier)
    {
        InitializeComponent();
        _listOfDroids = listOfDroids;
        resetFields();
        btnUpdateDroid.Enabled = false;
        DroidFactoryBoolCarrier = boolCarrier;
    }

    public DroidFactory(List<Droid> listOfDroids, Droid droid, int dictionaryIndex, BoolCarrier boolCarrier)
    {
        InitializeComponent();
        _isUpdating = true;
        txtId.Enabled = false;
        _listOfDroids = listOfDroids;
        _dictionaryIndex = dictionaryIndex;
        btnCreateDroid.Enabled = false;
        DroidFactoryBoolCarrier = boolCarrier;

        resetFields();

        _droid = droid;
        txtId.Text = _droid.Id.ToString();
        txtModel.Text = _droid.Model.ToString();
        txtManufacturer.Text = _droid.Manufacturer.ToString();
        txtHeight.Text = _droid.Height.ToString();
        txtMass.Text = _droid.Mass.ToString();

        if ((ETypesOfDroids)_droid.DroidType == ETypesOfDroids.BattleDroid)
        {
            cbTypeOfDroid.SelectedIndex = 1;
            cbEquipment1.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Equipment1) +1 ;
            cbEquipment2.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Equipment2) +1 ;
            cbEquipment3.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Equipment3) + 1;
            cbEquipment4.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Equipment4) + 1;
            cbArmament1.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Armament1) + 1;
            cbArmament2.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Armament2) + 1;
            cbArmament3.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Armament3) + 1;
            cbArmament4.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Armament4) + 1;
            cbPlating.SelectedIndex = Convert.ToInt32((_droid as BattleDroid).Plating) + 1;
        }
        else if ((ETypesOfDroids)_droid.DroidType == ETypesOfDroids.AssassinDroid)
        {
            cbTypeOfDroid.SelectedIndex = 2;
            cbEquipment1.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Equipment1) + 1;
            cbEquipment2.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Equipment2) + 1;
            cbEquipment3.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Equipment3) + 1;
            cbEquipment4.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Equipment4) + 1;
            cbArmament1.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Armament1) + 1;
            cbArmament2.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Armament2) + 1;
            cbArmament3.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Armament3) + 1;
            cbArmament4.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Armament4) + 1;
            cbPlating.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).Plating) + 1;
            cbAiChip.SelectedIndex = Convert.ToInt32((_droid as AssassinDroid).AiChip) + 1;
        }
        else
        {
            cbTypeOfDroid.SelectedIndex = 3;
            cbEquipment1.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment1) + 1;
            cbEquipment2.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment2) + 1;
            cbEquipment3.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment3) + 1;
            cbEquipment4.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment4) + 1;
            cbEquipment5.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment5) + 1;
            cbEquipment6.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Equipment6) + 1;
            cbPlating.SelectedIndex = Convert.ToInt32((_droid as AstroMechDroid).Plating) + 1;
        }
    }
    private void cbTypeOfDroid_SelectedIndexChanged(object sender, EventArgs e)
    {
        cbEquipment1.Enabled = false;
        cbEquipment2.Enabled = false;
        cbEquipment3.Enabled = false;
        cbEquipment4.Enabled = false;
        cbEquipment5.Enabled = false;
        cbEquipment6.Enabled = false;
        cbArmament1.Enabled = false;
        cbArmament2.Enabled = false;
        cbArmament3.Enabled = false;
        cbArmament4.Enabled = false;
        cbArmament5.Enabled = false;
        cbArmament6.Enabled = false;
        cbPlating.Enabled = false;
        cbAiChip.Enabled = false;

        switch (cbTypeOfDroid.SelectedIndex)
        {
            case 1:
                cbEquipment1.Enabled = true;
                cbEquipment2.Enabled = true;
                cbEquipment3.Enabled = true;
                cbEquipment4.Enabled = true;
                cbArmament1.Enabled = true;
                cbArmament2.Enabled = true;
                cbArmament3.Enabled = true;
                cbArmament4.Enabled = true;
                cbPlating.Enabled = true;
                break;

            case 2:
                cbEquipment1.Enabled = true;
                cbEquipment2.Enabled = true;
                cbEquipment3.Enabled = true;
                cbEquipment4.Enabled = true;
                cbArmament1.Enabled = true;
                cbArmament2.Enabled = true;
                cbArmament3.Enabled = true;
                cbArmament4.Enabled = true;
                cbPlating.Enabled = true;
                cbAiChip.Enabled = true;
                break;

            case 3:
                cbEquipment1.Enabled = true;
                cbEquipment2.Enabled = true;
                cbEquipment3.Enabled = true;
                cbEquipment4.Enabled = true;
                cbEquipment5.Enabled = true;
                cbEquipment6.Enabled = true;
                cbPlating.Enabled = true;
                break;
        }
    }
    private void btnCreateDroid_Click(object sender, EventArgs e)
    {
        Droid droidToAdd;

        ETypesOfDroids droidType = (ETypesOfDroids)cbTypeOfDroid.SelectedIndex -1;

        if (droidType == ETypesOfDroids.BattleDroid)
        {
            droidToAdd = new BattleDroid(
                (EArmament)cbArmament1.SelectedIndex -1,
                (EArmament)cbArmament2.SelectedIndex -1,
                (EArmament)cbArmament3.SelectedIndex -1,
                (EArmament)cbArmament4.SelectedIndex -1,
                (EPlating)cbPlating.SelectedIndex -1);

        }
        else if (droidType == ETypesOfDroids.AssassinDroid)
        {
            droidToAdd = new AssassinDroid(

            (EArmament)cbArmament1.SelectedIndex - 1,
            (EArmament)cbArmament2.SelectedIndex - 1,
            (EArmament)cbArmament3.SelectedIndex - 1,
            (EArmament)cbArmament4.SelectedIndex - 1,
            (EPlating)cbPlating.SelectedIndex - 1,
            (EAIChip)cbAiChip.SelectedIndex - 1);
        }
        else if (droidType == ETypesOfDroids.AstroMechDroid)
        {
            droidToAdd = new AstroMechDroid(
            (EEquipment)cbEquipment5.SelectedIndex -1,
            (EEquipment)cbEquipment6.SelectedIndex -1,
            (EPlating)cbPlating.SelectedIndex -1
            );
        }
        else
        {
            MessageBox.Show("Error - The Droid Type Cannot be Undefined",
                         "Undefined Type",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return;
        }

        droidToAdd.DroidType = (ETypesOfDroids)cbTypeOfDroid.SelectedIndex -1;

        if (!areAlltxtFieldsOk(droidToAdd))
        {
            return;
        }
        
        droidToAdd.Id = Convert.ToInt32(txtId.Text);
        droidToAdd.Model = txtModel.Text;
        droidToAdd.Manufacturer = txtManufacturer.Text;
        droidToAdd.Height = Convert.ToSingle(txtMass.Text);
        droidToAdd.Mass = Convert.ToSingle(txtHeight.Text);
        droidToAdd.Equipment1 = (EEquipment)cbEquipment1.SelectedIndex - 1;
        droidToAdd.Equipment2 = (EEquipment)cbEquipment2.SelectedIndex - 1;
        droidToAdd.Equipment3 = (EEquipment)cbEquipment3.SelectedIndex - 1;
        droidToAdd.Equipment4 = (EEquipment)cbEquipment4.SelectedIndex - 1;

        _listOfDroids.Add(droidToAdd);

        var result = MessageBox.Show("Droid Manufactured Successfully!",
                         "Droid Creation",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
        resetFields();
        DroidFactoryBoolCarrier.MyBool = true;
        return;
    }

    private void btnUpdateDroid_Click(object sender, EventArgs e)
    {
        if (!areAlltxtFieldsOk(_droid))
        {
            return;
        }

        _listOfDroids.RemoveAt(_dictionaryIndex);

        if (cbTypeOfDroid.SelectedIndex == 1)
        {
            _droid = new BattleDroid(
                (EArmament)cbArmament1.SelectedIndex -1,
                (EArmament)cbArmament2.SelectedIndex -1,
                (EArmament)cbArmament3.SelectedIndex -1,
                (EArmament)cbArmament4.SelectedIndex -1,
                (EPlating)cbPlating.SelectedIndex -1);

            _droid.DroidType = ETypesOfDroids.BattleDroid;
        }
           
        else if (cbTypeOfDroid.SelectedIndex == 2)
        {
            _droid = new AssassinDroid(
                (EArmament)cbArmament1.SelectedIndex -1,
                (EArmament)cbArmament2.SelectedIndex -1,
                (EArmament)cbArmament3.SelectedIndex -1,
                (EArmament)cbArmament4.SelectedIndex -1,
                (EPlating)cbPlating.SelectedIndex -1,
                (EAIChip)cbAiChip.SelectedIndex -1);

            _droid.DroidType = ETypesOfDroids.AssassinDroid;
        }
        else
        {
            _droid = new AstroMechDroid(
                (EEquipment)cbEquipment5.SelectedIndex -1,
                (EEquipment)cbEquipment6.SelectedIndex -1,
                (EPlating)cbPlating.SelectedIndex -1);

            _droid.DroidType = ETypesOfDroids.AstroMechDroid;
        }

        _droid.Equipment1 = (EEquipment)cbEquipment1.SelectedIndex -1;
        _droid.Equipment2 = (EEquipment)cbEquipment2.SelectedIndex -1;
        _droid.Equipment3 = (EEquipment)cbEquipment3.SelectedIndex -1;
        _droid.Equipment4 = (EEquipment)cbEquipment4.SelectedIndex -1;
        _droid.Id = Convert.ToInt32(txtId.Text);
        _droid.Model = txtModel.Text;
        _droid.Manufacturer = txtManufacturer.Text;
        _droid.Height = Convert.ToSingle(txtHeight.Text);
        _droid.Mass = Convert.ToSingle(txtMass.Text);

        _listOfDroids.Insert(_dictionaryIndex, _droid);
        MessageBox.Show("Droid Updated Successfully!",
                         "Droid Update",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
        DroidFactoryBoolCarrier.MyBool = true;
        Close();
    }
    private void btnBackToMainMenu_Click(object sender, EventArgs e)
    {
        Close();
    }

    private bool areAlltxtFieldsOk(Droid droidToAdd)
    {

        if (!droidToAdd.IsDroidIdBetween1And10Digits(txtId.Text))
        {
            MessageBox.Show("Error - Droid Id is not composed of between 1 and 10 digits.",
                         "Invalid ID Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return false;
        }

        if (!_isUpdating)
        {
            if (droidToAdd.ContainsId(Convert.ToInt32(txtId.Text), _listOfDroids))
            {
                MessageBox.Show("Error - Droid Id not unique.",
                             "Invalid ID Input",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                return false;
            }
        }

        if (!droidToAdd.IsDroidModelOnly5CharsOrDigitsLong(txtModel.Text))
        {
            MessageBox.Show("Error - Droid Model is not composed of only 5 chars or digits.",
                         "Invalid Model Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return false;
        }
        if (!droidToAdd.IsDroidManufacturerBetween1And20CharsOrDigitsLong(txtManufacturer.Text))
        {
            MessageBox.Show("Error - Droid Manufacturer is not composed of 1 to 20 chars or digits.",
                         "Invalid Manufacturer Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return false;
        }
        if (!droidToAdd.IsDroidHeightOrMassUnder20FloatTypeDigits(txtHeight.Text))
        {
            MessageBox.Show("Error - Droid Height is not composed of under 20 digits.",
                         "Invalid Height Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return false;
        }
        if (!droidToAdd.IsDroidHeightOrMassUnder20FloatTypeDigits(txtMass.Text))
        {
            MessageBox.Show("Error - Droid Mass is not composed of under 20 digits.",
                         "Invalid Mass Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void DroidFactory_FormClosed(object sender, FormClosedEventArgs e)
    {
    }
}
