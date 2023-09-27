using System.Collections.Generic;
using UnityEngine;

public abstract class BattleCard : ScriptableObject
{
    public int defaultPower;
    public int consumedMagic;
    public List<CardAttribute> cardAttribute;

    public bool enableOnUse;
    public bool enableOnBattle;

    /// <summary>
    /// Žg—pŽžŒø‰Ê
    /// </summary>
    public abstract void OnUse();
    /// <summary>
    /// ‘ÎŒˆŽžŒø‰Ê
    /// </summary>
    public abstract void OnBattle();
}
public enum CardAttribute
{
    /// <summary>
    /// ‹Ø—Í
    /// </summary>
    MuscleStrength,

}
