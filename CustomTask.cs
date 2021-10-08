
public abstract class CustomTask
{
    private readonly AuditTrail _auditTrail;
    public CustomTask()
    {
        _auditTrail = new AuditTrail();
    }
    public CustomTask(AuditTrail auditTrail)
    {
        _auditTrail = auditTrail;
    }
    public void Execute()
    {
        _auditTrail.Record();
        DoExecute();
    }

    protected abstract void DoExecute();
}