namespace CalcRunPoc.Cmd.Model
{
    class Calculation
    {
        public AuditResult AuditTransaction(Transaction transaction)
        {
            var result = new AuditResult();

            var contract = FindContract();

            return result;
        }

        private Contract FindContract()
        {
            return new Contract();
        }
    }
}
