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
            if (col is TableHeaderPrototype)
            {
                row.Add(col.Clone()); // wywołanie metody klonującej
            }
            else
            {
                row.Add(col.CreateData()); // wywołanie metody fabrykującej
            }
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
            row.Add(type.CreateData()); // wywołanie metody fabrykującej
        }
    }

    /// <summary>
    /// Dodanie kolumny.
    /// </summary>
    /// <param name="type">Nagłówke przechowujący typ.</param>
    public void addCol(TableHeaderPrototype type)
    {
        headers.Add(type);
        foreach (var row in data)
        {
            row.Add(type.Clone()); // wywołanie metody klonującej
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
