public class Player
{
    #region プロパティ
    public MasterBorad MasterBorad { get; internal set; }
    public Servant ServantTurrets { get; internal set; }
    public int MagicToken { get; internal set; }
    /// <summary>
    /// 令呪みたいなやつ
    /// </summary>
    public int CommandSpell { get; internal set; }
    #endregion

    #region コンストラクタ
    internal Player()
    {
        
    }
    #endregion
}
