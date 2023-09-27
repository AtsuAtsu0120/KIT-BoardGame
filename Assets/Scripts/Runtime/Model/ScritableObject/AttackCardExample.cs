using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����Attribute���g����Unity��ScritableObject�𐶐��ł���B
[CreateAssetMenu]
public class AttackCardExample : AttackCard
{
    public override void OnBattle()
    {
        //�v���C���[�̓��f������擾����B
        var player = Model.GameMaster.Game.GetPlayerOnTurn();

        player.MagicToken += 2;
    }

    public override void OnUse()
    {
        var player = Model.GameMaster.Game.GetPlayerOnTurn();

        player.MagicToken += 10;
    }
}
