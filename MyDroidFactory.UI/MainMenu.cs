using MyDroidFactory.Business;
using Microsoft.Web.WebView2.Core;
using System.Media;
using MyDroidFactory.Business.Enums;
using MyDroidFactory.Data;
using System.Text.RegularExpressions;

namespace MyDroidFactory.UI
{
    public partial class MainMenu : Form
    {
        public List<Droid> listOfDroids = DroidBinaryData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new();
        BoolCarrier MainMenuBoolCarrier = new();

        public MainMenu()
        {
            InitializeComponent();
            refeshDisplayOfDroids(listOfDroids);
            wvDroidArmyVideo.Hide();
            cbDisplayType.SelectedIndex = 0;
        }

        private void btnCreateNewDroid_Click(object sender, EventArgs e)
        {
            BoolCarrier boolCarrier = new BoolCarrier();
            var droidFactory = new DroidFactory(listOfDroids, MainMenuBoolCarrier);
            droidFactory.FormClosed += DroidFactory_FormClosed;
            droidFactory.ShowDialog();
        }
        public int GetIndexFromDictionary()
        {
            ListView.SelectedIndexCollection indexesCollection = lvListOfDroids.SelectedIndices;
            if (indexesCollection.Count <= 0)
            {
                MessageBox.Show("Please select a Droid!",
                             "Invalid Droid Selection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                return -1;
            }

            if (indexesCollection.Count > 1)
            {
                MessageBox.Show("Please select only 1 Droid!",
                             "Invalid Droid Selection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                return -1;
            }

            return dictionaryOfIndexes[indexesCollection[0]];
        }

        private void btnUpdateDroid_Click(object sender, EventArgs e)
        {
            int droidIndex = GetIndexFromDictionary();
            if (droidIndex < 0)
            {
                return;
            }
            var droidFactory = new DroidFactory(listOfDroids, listOfDroids[droidIndex], droidIndex, MainMenuBoolCarrier);
            droidFactory.FormClosed += DroidFactory_FormClosed;
            droidFactory.ShowDialog();

        }
        private void btnSecureAllDroids_Click(object sender, EventArgs e)
        {
            DroidBinaryData.Save(listOfDroids);
            MessageBox.Show("Droids Secured. Stay safe, soldier.",
                             "Droids List Saved Successfully",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            MainMenuBoolCarrier.MyBool = false;
        }

        private void btnSellDroid_Click(object sender, EventArgs e)
        {
            int index = GetIndexFromDictionary();
            if (index == -1)
                return;
            var result = MessageBox.Show("Do you really want to Sell the selected droid to the Jawas?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            listOfDroids.RemoveAt(index);
            lvListOfDroids.Items.RemoveAt(index);
            MainMenuBoolCarrier.MyBool = true;
        }

        public void refeshDisplayOfDroids(List<Droid> listOfDroids)
        {
            lvListOfDroids.Items.Clear();
            dictionaryOfIndexes.Clear();

            int i = 0;

            if (cbDisplayType.SelectedIndex == 0)
            {
                foreach (Droid d in listOfDroids)
                {
                    var item = new ListViewItem(d.DroidType.ToString());
                    item.SubItems.Add(d.Id.ToString());
                    item.SubItems.Add(d.Model);
                    item.SubItems.Add(d.Manufacturer);
                    item.SubItems.Add(d.Height.ToString());
                    item.SubItems.Add(d.Mass.ToString());
                    item.SubItems.Add(d.Equipment1.ToString());
                    item.SubItems.Add(d.Equipment2.ToString());
                    item.SubItems.Add(d.Equipment3.ToString());
                    item.SubItems.Add(d.Equipment4.ToString());

                    switch (d.DroidType)
                    {
                        case ETypesOfDroids.BattleDroid:
                            {
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add((d as BattleDroid).Armament1.ToString());
                                item.SubItems.Add((d as BattleDroid).Armament2.ToString());
                                item.SubItems.Add((d as BattleDroid).Armament3.ToString());
                                item.SubItems.Add((d as BattleDroid).Armament4.ToString());
                                item.SubItems.Add((d as BattleDroid).Plating.ToString());
                                break;
                            }

                        case ETypesOfDroids.AssassinDroid:
                            {
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add((d as AssassinDroid).Armament1.ToString());
                                item.SubItems.Add((d as AssassinDroid).Armament2.ToString());
                                item.SubItems.Add((d as AssassinDroid).Armament3.ToString());
                                item.SubItems.Add((d as AssassinDroid).Armament4.ToString());
                                item.SubItems.Add((d as AssassinDroid).Plating.ToString());
                                item.SubItems.Add((d as AssassinDroid).AiChip.ToString());
                                break;
                            }

                        case ETypesOfDroids.AstroMechDroid:
                            {
                                item.SubItems.Add((d as AstroMechDroid).Equipment5.ToString());
                                item.SubItems.Add((d as AstroMechDroid).Equipment6.ToString());
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add("");
                                item.SubItems.Add((d as AstroMechDroid).Plating.ToString());
                                break;
                            }
                    }
                    dictionaryOfIndexes.Add(lvListOfDroids.Items.Count, i);
                    lvListOfDroids.Items.Add(item);
                    i++;
                }
            }

            else if (cbDisplayType.SelectedIndex == 1)
            {
                foreach (Droid d in listOfDroids)
                {
                    var item = new ListViewItem(d.DroidType.ToString());
                    if ((ETypesOfDroids)d.DroidType != ETypesOfDroids.BattleDroid)
                    {
                        continue;
                    }
                    item.SubItems.Add(d.Id.ToString());
                    item.SubItems.Add(d.Model);
                    item.SubItems.Add(d.Manufacturer);
                    item.SubItems.Add(d.Height.ToString());
                    item.SubItems.Add(d.Mass.ToString());
                    item.SubItems.Add(d.Equipment1.ToString());
                    item.SubItems.Add(d.Equipment2.ToString());
                    item.SubItems.Add(d.Equipment3.ToString());
                    item.SubItems.Add(d.Equipment4.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add((d as BattleDroid).Armament1.ToString());
                    item.SubItems.Add((d as BattleDroid).Armament2.ToString());
                    item.SubItems.Add((d as BattleDroid).Armament3.ToString());
                    item.SubItems.Add((d as BattleDroid).Armament4.ToString());
                    item.SubItems.Add((d as BattleDroid).Plating.ToString());
                    
                    dictionaryOfIndexes.Add(lvListOfDroids.Items.Count, i);
                    lvListOfDroids.Items.Add(item);
                    i++;
                }
            }
            else if (cbDisplayType.SelectedIndex == 2)
            {
                foreach (Droid d in listOfDroids)
                {
                    var item = new ListViewItem(d.DroidType.ToString());
                    if ((ETypesOfDroids)d.DroidType != ETypesOfDroids.AssassinDroid)
                    {
                        continue;
                    }
                    item.SubItems.Add(d.Id.ToString());
                    item.SubItems.Add(d.Model);
                    item.SubItems.Add(d.Manufacturer);
                    item.SubItems.Add(d.Height.ToString());
                    item.SubItems.Add(d.Mass.ToString());
                    item.SubItems.Add(d.Equipment1.ToString());
                    item.SubItems.Add(d.Equipment2.ToString());
                    item.SubItems.Add(d.Equipment3.ToString());
                    item.SubItems.Add(d.Equipment4.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add((d as AssassinDroid).Armament1.ToString());
                    item.SubItems.Add((d as AssassinDroid).Armament2.ToString());
                    item.SubItems.Add((d as AssassinDroid).Armament3.ToString());
                    item.SubItems.Add((d as AssassinDroid).Armament4.ToString());
                    item.SubItems.Add((d as AssassinDroid).Plating.ToString());
                    item.SubItems.Add((d as AssassinDroid).AiChip.ToString());

                    dictionaryOfIndexes.Add(lvListOfDroids.Items.Count, i);
                    lvListOfDroids.Items.Add(item);
                    i++;
                }
            }
            else if (cbDisplayType.SelectedIndex == 3)
            {
                foreach (Droid d in listOfDroids)
                {
                    var item = new ListViewItem(d.DroidType.ToString());
                    if ((ETypesOfDroids)d.DroidType != ETypesOfDroids.AstroMechDroid)
                    {
                        continue;
                    }
                    item.SubItems.Add(d.Id.ToString());
                    item.SubItems.Add(d.Model);
                    item.SubItems.Add(d.Manufacturer);
                    item.SubItems.Add(d.Height.ToString());
                    item.SubItems.Add(d.Mass.ToString());
                    item.SubItems.Add(d.Equipment1.ToString());
                    item.SubItems.Add(d.Equipment2.ToString());
                    item.SubItems.Add(d.Equipment3.ToString());
                    item.SubItems.Add(d.Equipment4.ToString());
                    item.SubItems.Add((d as AstroMechDroid).Equipment5.ToString());
                    item.SubItems.Add((d as AstroMechDroid).Equipment6.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add((d as AstroMechDroid).Plating.ToString());

                    dictionaryOfIndexes.Add(lvListOfDroids.Items.Count, i);
                    lvListOfDroids.Items.Add(item);
                    i++;
                }
            }
        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {
            string nameExpression = @"^[0-9]{1,10}$";
            if (!new Regex(nameExpression).IsMatch(txtIdSearch.Text))
            {
                    MessageBox.Show("Input a valid ID input please.",
                    "Invalid Search Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    refeshDisplayOfDroids(listOfDroids);
                return;
            }

            Droid d = listOfDroids.FirstOrDefault(s => s.Id == Convert.ToInt32(txtIdSearch.Text));

            if (d != null)
            {
                lvListOfDroids.Items.Clear();
                dictionaryOfIndexes.Clear();
                var item = new ListViewItem(d.DroidType.ToString());
                item.SubItems.Add(d.Id.ToString());
                item.SubItems.Add(d.Model);
                item.SubItems.Add(d.Manufacturer);
                item.SubItems.Add(d.Height.ToString());
                item.SubItems.Add(d.Mass.ToString());
                item.SubItems.Add(d.Equipment1.ToString());
                item.SubItems.Add(d.Equipment2.ToString());
                item.SubItems.Add(d.Equipment3.ToString());
                item.SubItems.Add(d.Equipment4.ToString());

                switch (d.DroidType)
                {
                    case ETypesOfDroids.BattleDroid:
                        {
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add((d as BattleDroid).Armament1.ToString());
                            item.SubItems.Add((d as BattleDroid).Armament2.ToString());
                            item.SubItems.Add((d as BattleDroid).Armament3.ToString());
                            item.SubItems.Add((d as BattleDroid).Armament4.ToString());
                            item.SubItems.Add((d as BattleDroid).Plating.ToString());
                            break;
                        }

                    case ETypesOfDroids.AssassinDroid:
                        {
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add((d as AssassinDroid).Armament1.ToString());
                            item.SubItems.Add((d as AssassinDroid).Armament2.ToString());
                            item.SubItems.Add((d as AssassinDroid).Armament3.ToString());
                            item.SubItems.Add((d as AssassinDroid).Armament4.ToString());
                            item.SubItems.Add((d as AssassinDroid).Plating.ToString());
                            item.SubItems.Add((d as AssassinDroid).AiChip.ToString());
                            break;
                        }

                    case ETypesOfDroids.AstroMechDroid:
                        {
                            item.SubItems.Add((d as AstroMechDroid).Equipment5.ToString());
                            item.SubItems.Add((d as AstroMechDroid).Equipment6.ToString());
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add((d as AstroMechDroid).Plating.ToString());
                            break;
                        }
                }
                dictionaryOfIndexes.Add(lvListOfDroids.Items.Count, 0);
                lvListOfDroids.Items.Add(item);
            }
            else
            {
                MessageBox.Show("No match found in the list for this ID!",
                "Invalid Search Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            MessageBox.Show($"Naboo Has been Successfully Conquered.{Environment.NewLine}" +
                $"{Environment.NewLine}- Darth Glauberius",
                "NEW MAIL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            timerAlarm.Dispose();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool exit = false;
            if (exit)
            {
                return;
            }
            else
            {
                string message;
                MessageBoxIcon icon;
                if (MainMenuBoolCarrier.MyBool)
                {
                    message = "*** THERE ARE UNSAVED CHANGES! ***\n\n" +
                              "Do you really want to exit?";
                    icon = MessageBoxIcon.Warning;
                }
                else
                {
                    message = "Do you really want to exit?";
                    icon = MessageBoxIcon.Information;
                }


                var result = MessageBox.Show(message,
                                             "Confirmation",
                                             MessageBoxButtons.YesNo,
                                             icon);
                if (result == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    stopDroidAudio();
                    exit = true;
                    ActiveForm.Dispose();
                    Environment.Exit(1);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void musicReset_Tick(object sender, EventArgs e)
        {
            playDroidAudio();
        }

        private void wvDroidArmyVideo_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            playDroidAudio();
            wvDroidArmyVideo.Hide();
        }

        private void wvDroidArmyVideo_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            pbLoading.Hide();
            wvDroidArmyVideo.Show();
        }

        private void playDroidAudio()
        {
            var simpleSound = new SoundPlayer(SoundFile);
            simpleSound.Play();
        }
        private void stopDroidAudio()
        {
            var simpleSound = new SoundPlayer(SoundFile);
            simpleSound.Stop();
        }

        private static string SoundFile => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "MainMenu.wav");

        private void DroidFactory_FormClosed(object sender, FormClosedEventArgs e)
        {
            refeshDisplayOfDroids(listOfDroids);
        }

        private void cbDisplayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refeshDisplayOfDroids(listOfDroids);
        }
    }
}

