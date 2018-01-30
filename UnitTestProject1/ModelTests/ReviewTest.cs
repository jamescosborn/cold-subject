using ColdSubject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdSubject.Tests.ModelTests
{
    [TestClass]
    public class ReviewTest
    {
        [TestMethod]
        public void InvalidReviewLengthTest()
        {
            //Arrange
            var review = new Review();
            var example = string.Join("", Enumerable.Range(0, 256).Select(n => "A"));
            review.ContentBody = example;

            //Act
            var result = review.IsValid();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidReviewLengthTest()
        {
            //Arrange
            var review = new Review();
            var example = string.Join("", Enumerable.Range(0, 255).Select(n => "A"));
            review.ContentBody = example;
            
            //Act
            var result = review.IsValid();
            
            //Assert
            Assert.IsTrue(result);
        }
    }
}
