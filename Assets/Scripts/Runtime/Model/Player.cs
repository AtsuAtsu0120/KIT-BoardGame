public class Player
{
    #region �v���p�e�B
    public MasterBorad MasterBorad { get; internal set; }
    public Servant ServantTurrets { get; internal set; }
    public int MagicToken { get; internal set; }
    /// <summary>
    /// �ߎ�݂����Ȃ��
    /// </summary>
    public int CommandSpell { get; internal set; }
    #endregion

    #region �R���X�g���N�^
    internal Player()
    {
        
    }
    #endregion
}
