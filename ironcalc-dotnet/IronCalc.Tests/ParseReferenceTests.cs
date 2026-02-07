using System.IO;
using Xunit;

namespace IronCalc.Tests;

public class ParseReferenceTests
{
    [Fact]
    public void ParseSimpleReference()
    {
        var bytes = File.ReadAllBytes("SimpleSum.xlsx");
        using var model = Model.LoadFromXlsxBytes(bytes, "en", "Europe/Oslo", "en");

        var cellRef = model.ParseReference("Sheet1!A1");
        Assert.NotNull(cellRef);
        Assert.Equal((uint)0, cellRef.Sheet);
        Assert.Equal(1, cellRef.Column);
        Assert.Equal(1, cellRef.Row);
    }
}
