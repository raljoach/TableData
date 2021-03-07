using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableData
{
    /* Table Row contains fields
     * Each field has a name and value
     */
    public class TableRow
    {
        private Dictionary<string, string> _fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public void Set(string column, string value)
        {
            column = column.Trim();
            if (_fields.ContainsKey(column))
            {
                _fields[column] = value;
            }
            else
            {
                _fields.Add(column, value);
            }
        }
    }
}
