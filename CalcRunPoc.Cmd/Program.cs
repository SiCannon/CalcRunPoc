using System.Collections.Generic;
using CalcRunPoc.Cmd.Audits;
using CalcRunPoc.Cmd.Model;

namespace CalcRunPoc.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var auditStream = FrancePubPer.Create();

            var sourceData = new SourceData();
            foreach (var transaction in sourceData.Transactions)
            {

            }
        }

        static void AuditByTerritoryAndSource()
        {
            var territories = new List<string> { "France", "Austria", "Germany", "Italy" };

            var sources = new List<SourceData>
            {
                new SourceData { Source = "Box Office" },
                new SourceData { Source = "Transmissions" },
            };

            var calc = new Calculation();

            foreach (var territory in territories)
            {
                foreach (var source in sources)
                {
                    var results = new List<AuditResult>();

                    foreach (var transaction in source.Transactions)
                    {
                        results.Add(calc.AuditTransaction(transaction));
                    }

                    PostResults(results);
                }
            }
        }

        static void PostResults(object results)
        {
            // store the results?
        }
    }
}
