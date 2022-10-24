using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;
public class TableHeaderBool : AbstractTableHeader
{
    public TableHeaderBool()
    {
        this.type = typeof(bool).ToString();
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return new TableDataBool();
    }
}
