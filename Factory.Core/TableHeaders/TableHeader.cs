using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;
public class TableHeader : AbstractTableHeader
{
    /// <summary>
    /// Konstruktor kolumny o nagłówku typu INT.
    /// </summary>
    public TableHeader(string typeName)
    {
        this.type = typeName;
    }
}
