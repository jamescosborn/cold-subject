using ColdSubject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColdSubject.Tests.ModelTests
{
    [TestClass]
    public class ProductModelTest
    {
        [TestMethod]
        public void NoReviewsTest()
        {
            //Arrange
            var product = new Product();

            //Act
            var rating = product.AverageRating();

            //Assert
            Assert.IsNull(rating);
        }

        [TestMethod]
        public void OneReviewTest()
        {
            //Arrange
            var product = new Product();
            product.Reviews.Add(new Review(){Rating = 4});

            //Act
            var rating = product.AverageRating();

            //Assert
            Assert.IsNotNull(rating);
            Assert.AreEqual(4, rating);
        }

        [TestMethod]
        public void ThreeReviewsTest()
        {
            //Arrange
            var product = new Product();
            product.Reviews.Add(new Review() { Rating = 1 });
            product.Reviews.Add(new Review() { Rating = 3 });
            product.Reviews.Add(new Review() { Rating = 5 });

            //Act
            var rating = product.AverageRating();

            //Assert
            Assert.IsNotNull(rating);
            Assert.AreEqual(3, rating);
        }
    }
}
