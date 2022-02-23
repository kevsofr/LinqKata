namespace LinqKata
{
    public class Car
    {
        public string Mark { get; set; } = string.Empty;
        public int Price { get; set; }
    }

    public class Equity
    {
        public string Code { get; set; } = string.Empty;
    }

    public class Bond
    {
        public string Code { get; set; } = string.Empty;
    }

    public class Analysis
    {
        public string EquityCode { get; set; } = string.Empty;
        public string BondCode { get; set; } = string.Empty;
    }

    public class Instrument
    {
        public string Code { get; set; } = string.Empty;
        public int Value { get; set; }
    }
}
