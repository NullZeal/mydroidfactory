using MyDroidFactory.Business.Enums;

namespace MyDroidFactory.Business;

[Serializable]
public class BattleDroid : Droid
{
    public EArmament Armament1 { get; set; }
    public EArmament Armament2 { get; set; }
    public EArmament Armament3 { get; set; }
    public EArmament Armament4 { get; set; }
    public EPlating Plating { get; set; }

    public BattleDroid(
        EArmament armament1,
        EArmament armament2,
        EArmament armament3,
        EArmament armament4,
        EPlating plating)
    {
        Armament1 = armament1;
        Armament2 = armament2;
        Armament3 = armament3;
        Armament4 = armament4;
        Plating = plating;
    }
}
