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
    /// 使用時効果
    /// </summary>
    public abstract void OnUse();
    /// <summary>
    /// 対決時効果
    /// </summary>
    public abstract void OnBattle();
}
public enum CardAttribute
{
    /// <summary>
    /// 筋力
    /// </summary>
    MuscleStrength,

}
