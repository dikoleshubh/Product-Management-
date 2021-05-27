using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement_Lin
{
    class ProductDataTable
    {
        public void CreateDataBleAndAddDefaultValues()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new[]
                {
                    new DataColumn("ProductID"),
                    new DataColumn("UserID"),
                    new DataColumn("Rating"),
                    new DataColumn("Review"),
                    new DataColumn("isLike")
                }
            );
            table.Rows.Add("1", "1", "5", "Good", "true");
            table.Rows.Add("2", "2", "8", "Nice", "true");
            table.Rows.Add("3", "3", "4", "Good", "true");
            table.Rows.Add("4", "4", "1", "Not Good", "false");
            table.Rows.Add("5", "5", "5", "Good", "true");
            table.Rows.Add("6", "6", "5", "Good", "true");
            table.Rows.Add("7", "7", "8", "Nice", "true");
            table.Rows.Add("8", "8", "7", "Good", "true");
            table.Rows.Add("9", "9", "10", "Nice", "true");
            table.Rows.Add("10", "10", "4.7", "Good", "true");

        }
    }   
}
