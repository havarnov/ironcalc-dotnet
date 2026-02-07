namespace IronCalc;

/// <summary>
/// A reference to a specific cell in a spreadsheet model:
/// </summary>
public class CellRef
{
    /// <summary>
    /// The 0-indexed sheet index.
    /// </summary>
    public uint Sheet { get; init; }

    /// <summary>
    /// The 1-indexed column index.
    /// </summary>
    public int Column { get; init; }

    /// <summary>
    /// The 1-indexed row index.
    /// </summary>
    public int Row { get; init; }
}
