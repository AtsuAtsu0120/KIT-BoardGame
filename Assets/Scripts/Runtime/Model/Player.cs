using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    #region �v���p�e�B
    public MasterBorad MasterBorad { get; internal set; }
    public ServantTurret ServantTurrets { get; internal set; }
    public int MagicToken { get; internal set; }
    public int CommandSpell { get; internal set; }
    #endregion

    #region �R���X�g���N�^
    internal Player()
    {
        
    }
    #endregion
}
