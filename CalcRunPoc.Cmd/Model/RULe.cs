namespace CalcRunPoc.Cmd.Model
{
    class Rule
    {
        public string Territory { get; set; }
        public string Right { get; set; }
        public string Source { get; set; }
        public decimal Percentage { get; set; }

        public Rule(string territory, string right, string source, decimal percentage)
        {
            Territory = territory;
            Right = right;
            Source = source;
            Percentage = percentage;
        }
    }
}
