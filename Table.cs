using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableData
{
    /* Table is a list of rows
     * Each row contains fields
     */
    public class Table
    {
        private List<TableRow> _rows = new List<TableRow>();

        public void Add(TableRow row)
        {
            _rows.Add(row);
        }

        public void ExportCsv(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
