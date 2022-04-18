using MyDroidFactory.Business.Enums;

namespace MyDroidFactory.Business;

[Serializable]
public class AstroMechDroid : Droid
{
    public EEquipment Equipment5 { get; set; }
    public EEquipment Equipment6 { get; set; }
    public EPlating Plating { get; set; }

    public AstroMechDroid(
        EEquipment equipment5,
        EEquipment equipment6,
        EPlating plating)

    {
        Equipment5 = equipment5;
        Equipment6 = equipment6;
        Plating = plating;
    }
}
