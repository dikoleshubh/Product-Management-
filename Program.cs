﻿using System;
using System.Collections.Generic;
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
               
            };

        }
    }
    
    
}
