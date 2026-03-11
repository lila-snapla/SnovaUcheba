using WeightHeightLib;

namespace ConvertationTests
{
    public class HeightTests
    {
        [Fact]
        public void FountConvertTest()
        {
           double Meters = 25;
           
            HeightConverter converter = new HeightConverter();

            double result = converter.ConvertHeightFT(25);

            Assert.Equal(82, Math.Round(result));
            Assert.Contains("Конвертация в футы: 25 метров в 82 футов", converter.History);
        }

        [Fact]
        public void MeterConvertTest()
        {
            double fouts = 82;

            HeightConverter converter = new HeightConverter();

            double result = converter.ConvertHeightM(fouts);

            Assert.Equal(25, Math.Round(result));
            Assert.Contains("Конвертация в метры: 82 футов в 25 метров", converter.History);
        }
    }

    public class WeightTests
    {
        [Fact]
        public void KilosConvertTest()
        {
            double funts = 220;

            WeightConverter converter = new WeightConverter();

            double result = converter.ConvertWeightKG(funts);

            Assert.Equal(100, Math.Round(result));
            Assert.Contains("Конвертация в килограммы: 220 фунтов в 100 килограмм", converter.History);
        }

        [Fact]
        public void FuntsConvertTest()
        {
            double kilos = 100;

            WeightConverter converter = new WeightConverter();

            double result = converter.ConvertWeightFNT(kilos);

            Assert.Equal(220, Math.Round(result));
            Assert.Contains("Конвертация в фунты: 100 килограмм в 220 фунтов", converter.History);
        }
    }
    
    public class TempConvertTest()
    {
        [Fact]

        public void CelsiumsConvertTest()
        {
            double celsiums = -45;

            TempConverter converter = new TempConverter();
            
            double result = converter.ConvertCelsiums(celsiums);

            Assert.Equal(-1521, Math.Round(result));
            Assert.Contains("Конвертация в фарингейты: -45 цельсий в -1521 фарингейт", converter.History);
        }

        [Fact]

        public void FaringeitsConvertTest()
        {
            double farengeits = -1521;

            TempConverter converter = new TempConverter();

            double result = converter.ConvertFaringeits(farengeits);

            Assert.Equal(-45, Math.Round(result));
            Assert.Contains("Конвертация в цельсии: -1521 фарингейт в -45 цельсий", converter.History);
        }
    }
}