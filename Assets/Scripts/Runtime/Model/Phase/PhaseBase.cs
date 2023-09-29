public abstract class PhaseBase
{
    internal abstract void OnEnter();
    internal abstract PhaseBase GetNextPhase();
}
