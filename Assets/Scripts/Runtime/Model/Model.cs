public static class Model
{
    public static GameMaster GameMaster { get; private set; }
    static Model()
    {
        GameMaster = new();
    }
}
