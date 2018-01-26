using ColdSubject.Controllers;
using ColdSubject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColdSubject.Tests.ControllerTests
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void ProductsController_IndexModelContainsCorrectData_List()
        {
            Mock<IProductRepository> mock = MockRepository();

            //Arrange
            var controller = new ProductsController(mock.Object);
            var actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Product>));
        }

        [TestMethod]
        public void ProductsController_IndexModelContainsCorrectData_Detail()
        {
            var mock = MockRepository();
            var controller = new ProductsController(mock.Object);
            var detailResult = controller.Details(2);
            var ViewResult = detailResult as ViewResult;

            var detailModel = ViewResult.ViewData.Model as Product;

            Assert.IsInstanceOfType(detailModel, typeof(Product));
            Assert.AreEqual("Do the dishes", detailModel.Description);
        }

        private static Mock<IProductRepository> MockRepository()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, Description = "Wash the dog" },
                new Product {ProductId = 2, Description = "Do the dishes" },
                new Product {ProductId = 3, Description = "Sweep the floor" }
            }.AsQueryable());
            return mock;
        }
    }
}
