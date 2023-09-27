using System;
using System.Collections.Generic;

public class Game
{
    #region �v���p�e�B
    public string Guid { get; private set; }
    public Field Field { get; set; } = new();
    public List<Player> Players { get; set; } = new();
    public PhaseBase Phase { get; set; } = new InitializationPhase();
    #endregion

    #region �R���X�g���N�^
    internal Game()
    {
        Guid = System.Guid.NewGuid().ToString();
    }
    #endregion

    #region Internal���\�b�h
    internal void ChangePhase()
    {

    }
    internal Player GetPlayerOnTurn()
    {
        return new();
    }
    #endregion
}
