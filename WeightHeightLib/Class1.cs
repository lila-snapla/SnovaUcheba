using System.Diagnostics.Metrics;

namespace WeightHeightLib
{
    public class HeightConverter
    {
       public List<string> History = new List<string>();
        public double ConvertHeightFT(double meters)
        {
            double result = meters * 3.28;
            History.Add($"Конвертация в футы: {meters} метров в {Math.Round(result)} футов");
            return Math.Round(result);
        }
       public double ConvertHeightM(double fouts)
        {
            double result = fouts / 3.28;
            History.Add($"Конвертация в метры: {fouts} футов в {Math.Round(result)} метров");
            return Math.Round(result);
        }

        public void ClearHistory()
        {
            History.Clear();
        }
    }
    public class WeightConverter
    {
        public List<string> History = new List<string>();

        public double ConvertWeightFNT(double kilo)
        {
            double result = kilo * 2.2;
            History.Add($"Конвертация в фунты: {kilo} килограмм в {Math.Round(result)} фунтов");
            return Math.Round(result);
        }
        public double ConvertWeightKG(double funts)
        {
            double result = funts / 2.2;
            History.Add($"Конвертация в килограммы: {funts} фунтов в {Math.Round(result)} килограмм");
            return Math.Round(result);
        }

        public void ClearHistory()
        {
            History.Clear();
        }
    }
    public class TempConverter
    {
        public List<string> History = new List<string>();
        public double ConvertCelsiums(double celsiums)
        {
            double result = celsiums * 33.8;
            History.Add($"Конвертация в фарингейты: {celsiums} цельсий в {Math.Round(result)} фарингейт");
            return Math.Round(result);  
        }
        public double ConvertFaringeits(double farengeit)
        {
            double result = farengeit / 33.8;
            History.Add($"Конвертация в цельсии: {farengeit} фарингейт в {Math.Round(result)} цельсий");
            return Math.Round(result);
        }

        public void ClearHistory()
        {
            History.Clear();
        }
    }
}
