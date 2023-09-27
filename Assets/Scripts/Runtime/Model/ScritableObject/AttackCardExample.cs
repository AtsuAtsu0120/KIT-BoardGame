using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//このAttributeを使うとUnityでScritableObjectを生成できる。
[CreateAssetMenu]
public class AttackCardExample : AttackCard
{
    public override void OnBattle()
    {
        //プレイヤーはモデルから取得する。
        var player = Model.GameMaster.Game.GetPlayerOnTurn();

        player.MagicToken += 2;
    }

    public override void OnUse()
    {
        var player = Model.GameMaster.Game.GetPlayerOnTurn();

        player.MagicToken += 10;
    }
}
