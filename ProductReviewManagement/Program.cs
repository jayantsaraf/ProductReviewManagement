﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program");
            List<ProductReview> listOfProducts = new List<ProductReview>() {
                new ProductReview() { ProducID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 2, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 3, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 4, UserID = 3, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { ProducID = 5, UserID = 1, Rating = 2, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 6, UserID = 4, Rating = 1, Review = "Bad", isLike = true },
                new ProductReview() { ProducID = 8, UserID = 1, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { ProducID = 8, UserID = 5, Rating = 9, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 2, UserID = 2, Rating = 10, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 10, UserID = 4, Rating = 8, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 11, UserID = 5, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 12, UserID = 2, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 12, UserID = 4, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 13, UserID = 6, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 14, UserID = 3, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { ProducID = 15, UserID = 4, Rating = 2, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 15, UserID = 1, Rating = 1, Review = "Bas", isLike = true },
                new ProductReview() { ProducID = 15, UserID = 5, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { ProducID = 18, UserID = 1, Rating = 9, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 19, UserID = 2, Rating = 10, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 20, UserID = 3, Rating = 8, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 21, UserID = 2, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 22, UserID = 5, Rating = 10, Review = "Nice", isLike = true },
                new ProductReview() { ProducID = 22, UserID = 4, Rating = 8, Review = "Good", isLike = true },
                new ProductReview() { ProducID = 25, UserID = 3, Rating = 3, Review = "Bad", isLike = true }
                };
            Manager manager = new Manager();
            //manager.TopRecords(listOfProducts);
            //manager.SelectedRecords(listOfProducts);
            //manager.RetrieveCount(listOfProducts);
            //manager.RetrieveProductIDandReview(listOfProducts);
            manager.SkipFirstFiveRecords(listOfProducts);
        }
    }
}
