using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;

/// <summary>
/// Klasa nagłówka kolumny implementującej metodę fbrykującą.
/// </summary>
public abstract class AbstractTableHeader : ITableHeader
{
    /// <summary>
    /// Nazwa typu.
    /// </summary>
    protected string type;

    /// <summary>
    /// Konstruktor kolumny implementującej metodę fabrykującą.
    /// </summary>
    public AbstractTableHeader()
    {
        type = "null";
    }

    /// <summary>
    /// Pobranie nazwy typu.
    /// </summary>
    /// <returns>Nazwa typu.</returns>
    public override string ToString() => type;
}
