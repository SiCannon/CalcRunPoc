using System.Collections.Generic;

namespace CalcRunPoc.Cmd.Model
{
    class AuditStream
    {
        public List<Contract> Contracts { get; set; }


        public AuditStream()
        {
            Contracts = new List<Contract>();
        }
    }
}
