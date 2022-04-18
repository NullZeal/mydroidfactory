using MyDroidFactory.Business.Enums;
using System.Text.RegularExpressions;

namespace MyDroidFactory.Business;

[Serializable]
public abstract class Droid
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public float Height { get; set; }
    public float Mass { get; set; }
    public EEquipment Equipment1 { get; set; }
    public EEquipment Equipment2 { get; set; }
    public EEquipment Equipment3 { get; set; }
    public EEquipment Equipment4 { get; set; }
    public ETypesOfDroids DroidType { get; set; }

    protected Droid()
    {
    }

    protected Droid(
        int id, 
        string model, 
        string manufacturer,
        float height,
        float mass)
    {
        Id = id;
        Model = model;
        Manufacturer = manufacturer;
        Height = height;
        Mass = mass;
    }

    protected Droid(
        int id,
        string model,
        string manufacturer,
        float height,
        float mass,
        EEquipment equipment1) 
        : this(id, model, manufacturer, height, mass)
    {
        Equipment1 = equipment1;
    }

    protected Droid(
        int id,
        string model,
        string manufacturer,
        float height,
        float mass,
        EEquipment equipment1,
        EEquipment equipment2) : this(id, model, manufacturer, height, mass, equipment1)
    {
        Equipment2 = equipment2;
    }

    protected Droid(
        int id,
        string model,
        string manufacturer,
        float height,
        float mass,
        EEquipment equipment1,
        EEquipment equipment2,
        EEquipment equipment3) : this(id, model, manufacturer, height, mass, equipment1, equipment2)
    {
        Equipment3 = equipment3;
    }

    protected Droid(
        int id,
        string model,
        string manufacturer,
        float height,
        float mass,
        EEquipment equipment1,
        EEquipment equipment2,
        EEquipment equipment3,
        EEquipment equipment4) : this(id, model, manufacturer, height, mass, equipment1, equipment2, equipment3)
    {
        Equipment4 = equipment4;
    }

    public override string ToString()
    {
        return DroidType.ToString();
    }

    public virtual bool ContainsId(int id, List<Droid> list)
    {
         return list.Any(d => d.Id == id);
    }

    public virtual bool IsDroidModelOnly5CharsOrDigitsLong(string model)
    {
        return Regex.IsMatch(model, @"^[A-z0-9]{5}$");
    }

    public virtual bool IsDroidManufacturerBetween1And20CharsOrDigitsLong(string model)
    {
        return Regex.IsMatch(model, @"^[A-z0-9]{1,20}$");
    }

    public virtual bool IsDroidHeightOrMassUnder20FloatTypeDigits(string height)
    {
        return Regex.IsMatch(height, @"^([0-9]+([.][0-9]*)?|[.][0-9]+)$");
    }
    public virtual bool IsDroidIdBetween1And10Digits(string id)
    {
        return Regex.IsMatch(id, @"^\d{1,10}$");
    }
}
