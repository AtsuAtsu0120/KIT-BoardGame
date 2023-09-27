using System;
using System.Collections.Generic;

public class Game
{
    #region プロパティ
    public string Guid { get; private set; }
    public Field Field { get; set; } = new();
    public List<Player> Players { get; set; } = new();
    public PhaseBase Phase { get; set; } = new InitializationPhase();
    #endregion

    #region コンストラクタ
    internal Game()
    {
        Guid = System.Guid.NewGuid().ToString();
    }
    #endregion

    #region Internalメソッド
    internal void ChangePhase()
    {

    }
    internal Player GetPlayerOnTurn()
    {
        return new();
    }
    #endregion
}
