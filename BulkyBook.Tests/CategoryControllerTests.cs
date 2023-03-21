using System;
using Xunit;
using BulkyBookWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.Models;

namespace BulkyBook.Tests
{
    public class CategoryControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            // Arrange
            var controller = new CategoryController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Post_ReturnsCorrectView()
        {
            // Arrange
            var controller = new CategoryController();
            var category = new Category
            {
                WeightInKg = 67,
                HeightInCm = 183
            };

            // Act
            var result = controller.Index(category) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.Equal(category, result.Model);
        }
    }
}