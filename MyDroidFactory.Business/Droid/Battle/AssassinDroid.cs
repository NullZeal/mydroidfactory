using MyDroidFactory.Business.Enums;

namespace MyDroidFactory.Business;

[Serializable]
public class AssassinDroid : BattleDroid
{
    public EAIChip AiChip { get; set;} 

    public AssassinDroid(
        EArmament armament1,
        EArmament armament2,
        EArmament armament3,
        EArmament armament4,
        EPlating plating,
        EAIChip aiChip)
        : base(armament1, armament2, armament3, armament4, plating)
    {
        AiChip = aiChip;
    }
}
