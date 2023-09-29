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
    /// �g�p������
    /// </summary>
    public abstract void OnUse();
    /// <summary>
    /// �Ό�������
    /// </summary>
    public abstract void OnBattle();
}
public enum CardAttribute
{
    /// <summary>
    /// �ؗ�
    /// </summary>
    MuscleStrength,

}
