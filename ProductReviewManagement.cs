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
    }
}
