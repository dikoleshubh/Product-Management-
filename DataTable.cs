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
                   table.Columns.Add("ProductId", typeof(Int32));
                   table.Columns.Add("UserId", typeof(Int32));
                   table.Columns.Add("Rating", typeof(double));
                   table.Columns.Add("Review", typeof(string));
                   table.Columns.Add("IsLike", typeof(bool));
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
        public void DisplayDataTableRecordsWithIsLikeValueTrue(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["isLike"].Equals(true)); //SPECIFIC DATA DISPLAY
            Console.WriteLine("\nList Of records whose isLike value is True");
            foreach (var row in records)
            {

                Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " ");

            }
        }
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
        // Retrieve DataTable records who's Review is Nice
        public void RetrievRecordsWhoseReviewIsNice(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["Review"].Equals("Nice"));
            Console.WriteLine("\nList Of Products whose Review is Nice");
            foreach (var row in records)
            {
             
                Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " ");
               
            }
        }
        // Retrieve DataTable records who's UserID is 10, order by rating
        public void RetrievRecordsOfPerticularUserID(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .OrderBy(x => x.Field<float>("Rating"))
                          .Where(x => x["UserID"].Equals(10));
            Console.WriteLine("\nList Of Products whose UserID is 10");
            foreach (var row in records)
            {
                Console.Write("\nProductID : " + row.Field<int>("ProductID") + " " + "\nUserID : " + row.Field<int>("UserID") + " " + "\nRating : " + row.Field<float>("Rating") + " " + "\nReview : " + row.Field<string>("Review") + " " + "\nisLike : " + row.Field<bool>("isLike") + " ");
                
            }
        }
    }   
}
