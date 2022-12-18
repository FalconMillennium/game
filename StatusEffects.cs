using Newtonsoft.Json;
using System;

public class StatusEffects : Game //could use it for potions as well
{
    public ulong TargetTurn { get; set; }
    public ulong CurrentTurn { get; set; } = TurnNumber;
    public string Name { get; set; }
    public ulong Duration { get; set; }
    public int Potency { get; set; }
    public StatusType Type { get; set; }
    public Target Target { get; set; }
    public static string target;
    //

    public void Healing(string target)
    {
        if (target == "Player") _playerHP += Potency;
        else _enemyHP += Potency;
    }
/*    static StatusEffects()
    {


    }*/
    public StatusEffects(string target)
    {
        SpellProperties spell = new();
        Duration = spell.Duration;
        Potency = spell.Potency;
        Target effectTarget = (Target)Enum.Parse(typeof(Target), target);
        TargetTurn = CurrentTurn + Duration;
        for (; CurrentTurn <= TargetTurn; CurrentTurn++)
        {
            if (effectTarget == (Target)1)
                Healing("Player");
            else if (effectTarget == (Target)2)
                Healing("Enemy");
        }
    }
    public StatusEffects(ref int HP)
    {


    }
    public StatusEffects()
    {
    }
}
public enum StatusType {Healing = 1, Damage, DamageBoost, ArmorBoost /*TODO: implement armor*/ }
public enum Target { Player = 1, Enemy }