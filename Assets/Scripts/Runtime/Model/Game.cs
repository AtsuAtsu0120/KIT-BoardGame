using System;
using System.Collections.Generic;

public class Game
{
    #region プロパティ
    public string guid { get; private set; }
    public Field field { get; set; } = new();
    public List<Player> players { get; set; } = new();
    public Phase phase { get; set; } = new();
    #endregion

    #region コンストラクタ

    internal Game()
    {
        guid = Guid.NewGuid().ToString();
    }
    #endregion
}
