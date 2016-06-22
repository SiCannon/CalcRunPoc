using System.Collections.Generic;
using CalcRunPoc.Cmd.Model;

namespace CalcRunPoc.Cmd.Audits
{
    class FrancePubPer
    {
        public static AuditStream Create()
        {

            var sacem = new Contract
            {
                Rules = new List<Rule>
                {
                    new Rule("France", null, "Box Office", 2.0m),
                    new Rule("France", null, "Transmissions", 3.0m)
                }
            };

            var subpub = new Contract
            {
                Rules = new List<Rule>
                {
                    new Rule("France", null, "Box Office", 2.0m),
                    new Rule("France", null, "Box Office", 2.0m),
                }
            };

            var admin = new Contract
            {
                Rules = new List<Rule>
                {
                    new Rule(null, null, null, 50.0m),
                }
            };

            var result = new AuditStream();
            result.Contracts.Add(sacem);
            result.Contracts.Add(subpub);
            result.Contracts.Add(admin);
            return result;
        }
    }
}
