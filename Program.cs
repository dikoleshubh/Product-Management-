﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement_Lin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Project");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                
                new ProductReview(){ ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 2, UserID = 2, Rating = 8, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 3, UserID = 3, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 4, UserID = 4, Rating = 1, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 5, UserID = 5, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 6, UserID = 6, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 7, UserID = 7, Rating = 8, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 8, UserID = 8, Rating = 7, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 9, UserID = 9, Rating = 10, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 10, UserID = 10, Rating = 4.7, Review = "Good", isLike=true },

            };
            foreach (var list in productReviewList) //Displaying All records
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID " + list.ProductID + "\nUserID " + list.UserID + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
                Console.WriteLine("\n-----------------");
            }
            //Object has been created
            ProductReviewManagement management = new ProductReviewManagement();
            management.TopRecords(productReviewList);
            management.SelectedRecords(productReviewList);
            management.RetrieveCountOfRecords(productReviewList);
            management.RetrieveProductIDAndReviewFromList(productReviewList);
            management.DisplayUnskippedRecords(productReviewList);

            //DATA TABLE OPERATIONS
            Console.WriteLine("\nDataTable Operations");
            ProductDataTable reviewDataTable = new ProductDataTable(); //OBJECT CREATION
            DataTable table = reviewDataTable.CreateDataBleAndAddDefaultValues();//UC-7
            reviewDataTable.DisplayDataTableRecordsWithIsLikeValueTrue(table);//UC-08
            reviewDataTable.FindAverageRatingOfEachProductID(table);//UC-09
            reviewDataTable.RetrievRecordsWhoseReviewIsNice(table);//UC-10
            reviewDataTable.RetrievRecordsOfPerticularUserID(table); //UC-11
            Console.ReadKey();
        }
    }
    
    
}
