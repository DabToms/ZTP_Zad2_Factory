using Factory.Core.TableDatas;
using Factory.Core.TableHeaders;

namespace Factory.Core;

/// <summary>
/// Baza danych zarządzająca kolumnami i wierszami przechowujące dane.
/// </summary>
public class Database
{
    /// <summary>
    /// Lista nagłówków.
    /// </summary>
    private List<ITableHeader> headers;

    /// <summary>
    /// Wiersz z danymi(mogą być różnego typów).
    /// </summary>
    private List<List<ITableData>> data;

    /// <summary>
    /// Konstruktor klasy Database.
    /// </summary>
    public Database()
    {
        headers = new List<ITableHeader>();
        data = new List<List<ITableData>>();
    }

    /// <summary>
    /// Dodanie wiersza.
    /// </summary>
    public void addRow()
    {
        List<ITableData> row = new List<ITableData>();
        foreach (var col in headers)
        {
                row.Add(new TableDataInt()); // wywołanie metody fabrykującej
        }
        data.Add(row);
    }

    /// <summary>
    /// Dodanie kolumny.
    /// </summary>
    /// <param name="type">Nagłówek przechowujący typ.</param>
    public void addCol(AbstractTableHeader type)
    {
        headers.Add(type);
        foreach (var row in data)
        {
            row.Add(new TableDataInt()); // wywołanie metody fabrykującej
        }
    }

    /// <summary>
    /// Pobranie tablicy z nagłówkami.
    /// </summary>
    /// <returns></returns>
    public List<ITableHeader> GetHeaders() => this.headers;

    /// <summary>
    /// Pobranie tablicy z danymi.
    /// </summary>
    /// <returns></returns>
    public List<List<ITableData>> GetData() => this.data;

    /// <summary>
    /// Wyczyszczenie tablicy z nagłówkami.
    /// </summary>
    /// <returns></returns>
    public void ClearHeaders() => this.headers.Clear();

    /// <summary>
    /// Wyczyszczenie tablicy z danymi.
    /// </summary>
    /// <returns></returns>
    public void ClearData() => this.data.Clear();
}
