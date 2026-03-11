using WeightHeightLib;

namespace DirectConvertationTests;

public class HistoryTests
{
    [Fact]
    public void HeightHistory()
    {
        HeightConverter converter = new HeightConverter();
        converter.ClearHistory();
        Assert.Empty(converter.History);
    }

    [Fact]
    public void WeightHistory()
    {
        WeightConverter converter = new WeightConverter();
        converter.ClearHistory();
        Assert.Empty(converter.History);
    }

    [Fact]

    public void TempHistory()
    {
        TempConverter converter = new TempConverter();
        converter.ClearHistory();
        Assert.Empty(converter.History);
    }
}
