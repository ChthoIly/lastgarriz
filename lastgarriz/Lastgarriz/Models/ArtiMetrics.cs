namespace Run.Models
{
    internal sealed class ArtiMetrics
    {
        internal double MilliradianBase { get; private set; }
        internal double MeterRatio { get; private set; }
        internal int MeterMinValue { get; private set; } = 100;
        internal int MeterMaxValue { get; private set; } = 1600;

        internal ArtiMetrics(bool rusianMetrics)
        {
            if (rusianMetrics)
            {
                //RU
                MilliradianBase = 1141.2;
                MeterRatio = 0.2133;
            }
            else
            {
                //US-GER
                MilliradianBase = 1001.68;
                MeterRatio = 0.23727;
            }
        }

        internal ArtiMetrics(int typeofMetrics)
        {
            switch (typeofMetrics)
            {
                case 1: //RU
                    MilliradianBase = 1141.2;
                    MeterRatio = 0.2133;
                    break;
                case 2: //UK
                    MilliradianBase = 550.728;
                    MeterRatio = 0.17733;
                    break;
                default: //US-GER
                    MilliradianBase = 1001.68;
                    MeterRatio = 0.23727;
                    break;
            }
        }
    }
}
