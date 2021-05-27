using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement_Lin
{
    class ProductReviewManagement
    {
        public void DisplayRecords(List<ProductReview> records)
        {
            foreach (var list in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID " + list.ProductID + "\nUserID " + list.UserID + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
                Console.WriteLine("\n-----------------");
            }
        }
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
    }
}
