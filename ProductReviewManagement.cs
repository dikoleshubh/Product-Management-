using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement_Lin
{
    class ProductReviewManagement
    {
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3).ToList();
            Console.WriteLine("Following are the records with top rating");
            DisplayRecords(recordData);
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              where ((productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                              && productReviews.Rating > 3)
                              select productReviews).ToList();
            Console.WriteLine("\nFollowing are the records with rating greater that 3 among Product ID 1, 4 and 5");
            DisplayRecords(recordData);
        }
        /// Retrieve count of review present fro each ProductID using Group By operator
        public void RetrieveOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("\nResult for Records Grouped By ProductID");
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductID + "-----" + list.Count);
            }
        }
        //Count of records
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("\nResult for Records Grouped By ProductID");
            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + "\t------>\tCount : " + list.Count);
            }
            Console.WriteLine("\n*");
        }
        /// Retrieve only Product ID and Review of Product
        public void RetrieveProductIDAndReviewFromList(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.Select(x => new { ProductID = x.ProductID, ProductReview = x.Review });
            Console.WriteLine("\nFollowing is List of Product Id and its Review ");
            foreach (var records in recordData)
            {

                Console.WriteLine("ProductID : " + records.ProductID + "\tProduct Review : " + records.ProductReview);
            }
            Console.WriteLine("\n*");
        }
        /// Skip First Records and Display other records
        public void DisplayUnskippedRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              select productReviews).Skip(5).ToList();
            Console.WriteLine("\nFollowing is List of records after skiping first 5 records");
            DisplayRecords(recordData);
        }
       
        public void DisplayRecords(List<ProductReview> records)
        { //Display respective records
            foreach (var list in records)
            {
                
                Console.Write("\nProductID " + list.ProductID + "\nUserID " + list.UserID + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);

            }
        }
    }
}
