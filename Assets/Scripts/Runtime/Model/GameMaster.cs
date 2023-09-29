
public class GameMaster
{
    #region プロパティ
    public Game Game { get; private set; } = new();

    #endregion

    #region コンストラクタ
    public GameMaster()
    {

    }
    #endregion

    #region publicメソッド
    public void NewGame()
    {
        Game = new();
    }
    #endregion
}
