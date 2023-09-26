using System;
using System.Collections.Generic;

public class Game
{
    #region �v���p�e�B
    public string guid { get; private set; }
    public Field field { get; set; } = new();
    public List<Player> players { get; set; } = new();
    public Phase phase { get; set; } = new();
    #endregion

    #region �R���X�g���N�^

    internal Game()
    {
        guid = Guid.NewGuid().ToString();
    }
    #endregion
}
