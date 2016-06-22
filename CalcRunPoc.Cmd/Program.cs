using System.Collections.Generic;
using CalcRunPoc.Cmd.Model;

namespace CalcRunPoc.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var collect = new AuditStream();

            var sacem = new Contract
            {
                Rules = new List<Rule>
                {
                    new Rule("France", null, "Box Office", 2.0m),
                    new Rule("France", null, "Transmissions", 3.0m)
                }
            };

            collect.Contracts.Add(sacem);

            var subpub = new Contract
            {
                Rules = new List<Rule>
                {
                    new Rule("France", null, "Box Office", 2.0m),
                    new Rule("France", null, "Box Office", 2.0m),
                }
            };

            collect.Contracts.Add(subpub);
        }
    }
}
