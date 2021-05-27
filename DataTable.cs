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
        public DataTable CreateDataBleAndAddDefaultValues() 
        {  //TABLE CREATED WITH DEFAULT VALUES
            DataTable table = new DataTable();
            table.Columns.AddRange(new[]  
                {                               //COLUMN NAMING
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
            table.Rows.Add("10", "10", "14.7", "Good", "true");
            return table;

        }
        //public void DisplayDataTableRecordsWithIsLikeValueTrue(DataTable table)
        //{
        //    var records = table.Rows.Cast<DataRow>()
        //                  .Where(x => x["isLike"].Equals(true)); //SPECIFIC DATA DISPLAY
        //    Console.WriteLine("\nList Of records whose isLike value is True");
        //    foreach (var row in records)
        //    {
               
        //        Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " ");
               
        //    }
        //}
        /// <summary>
        /// Average Rating
        /// </summary>
        /// <param name="table"></param>
        public void FindAverageRatingOfEachProductID(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .GroupBy(x => x.Field<int>("ProductID"))
                          .Select(x => new
                          {
                              ProductID = x.Key,
                              Average = x.Average(z => z.Field<float>("Rating"))
                          }).ToList();
            Console.WriteLine("\nList of Average Rating For Given Each Product ID");
            foreach (var row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID : " + row.ProductID + " " + "\nAverage Rating : " + row.Average);
               
            }
        }
    }   
}
