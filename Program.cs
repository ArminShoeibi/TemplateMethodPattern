
var transferMoneyTask = new TransferMoneyTask();
transferMoneyTask.Execute();


////////////////////////////////////////////////////////////////////////////////
class AuditTrail
{
    public void Record() => Console.WriteLine("Audit");
}
abstract class CustomTask
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

class GenerateReportTask : CustomTask
{
    protected override void DoExecute() => Console.WriteLine("Generate Report");
}

class TransferMoneyTask : CustomTask
{
    protected override void DoExecute() => Console.WriteLine("Transfer Money");
}
