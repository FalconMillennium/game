using Newtonsoft.Json;
using System;

public class StatusEffects : Game //could use it for potions as well
{
    public ulong TargetTurn { get; set; }
    public ulong CurrentTurn { get; set; }
    public string Name { get; set; }
    public ulong Duration { get; set; }
    public int Potency { get; set; }
    public StatusType Type { get; set; }
    public Target Target { get; set; }
    public static string target;

    public void Healing(string target)
    {
        if (target == "Player") _playerHP += Potency;
        else _enemyHP += Potency;
    }
/*    public delegate void ApplyEffect(ulong currentTurn, ulong targetTurn);
    ApplyEffect applyEffect = new(Healing);*/

/*    static StatusEffects()
    {


    }*/
/*
 ok this is cool but how do i apply this effect over several turns instead of all at once
what about:
1. spells method creates a new instance of status effects with parameters imported from json
2. that instance's method (healing etc) is called each turn till game's turn catches up with the target turn (get these from status effects instance)
 */
    public StatusEffects(StatusType type, ulong duration, int potency) 
    {
        CurrentTurn = TurnNumber;
        Potency = potency;
        TargetTurn = CurrentTurn + duration;
    }
    public StatusEffects()
    {
    }
}
public enum StatusType {Healing, Damage, DamageBoost, ArmorBoost /*TODO: implement armor*/ }
public enum Target { Self, Other, Both }
public enum EffectOrigin {Player, Enemy } //TODO: add origin-target effect handling