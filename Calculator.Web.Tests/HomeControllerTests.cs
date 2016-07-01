using System.Linq;
using System.Web.Mvc;
using Calculator.Web.Controllers;
using Calculator.Web.Models;
using Moq;
using NUnit.Framework;

namespace Calculator.Web.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Should_add_two_numbers()
        {
            // 1. Arrange

            double x = 2;
            double y = 3;

            var result = (x + y);
            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var model = new CalculatorModel {X = x.ToString(), Y = y.ToString()};

            mockCalculator.Setup(c => c.Add(x, y)).Returns(result);

            // 2. Act

            var viewResult = (homeController.Add(model) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);

            model = (viewResult.Model as CalculatorModel);

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Result, result.ToString());
        }

        [Test]
        public void Should_raise_vaildation_error_when_adding_where_X_is_not_a_number()
        {
            // 1. Arrange

            double y = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = "foo", Y = y.ToString() };

            // 2. Act

            var viewResult = (homeController.Add(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "X must be a number.");
        }

        [Test]
        public void Should_raise_vaildation_error_when_adding_where_Y_is_not_a_number()
        {
            // 1. Arrange

            double x = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = x.ToString(), Y = "bar" };

            // 2. Act

            var viewResult = (homeController.Add(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "Y must be a number.");
        }

        [Test]
        public void Should_subtract_two_numbers()
        {
            // 1. Arrange

            double x = 3;
            double y = 2;
            var result = (x - y);
            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var model = new CalculatorModel { X = x.ToString(), Y = y.ToString() };

            mockCalculator.Setup(c => c.Subtract(x, y)).Returns(result);

            // 2. Act

            var viewResult = (homeController.Subtract(model) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsNotNull(viewResult.Model);

            model = (viewResult.Model as CalculatorModel);

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Result, result.ToString());
        }

        [Test]
        public void Should_raise_vaildation_error_when_subtracting_where_X_is_not_a_number()
        {
            // 1. Arrange

            double y = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = "foo", Y = y.ToString() };

            // 2. Act

            var viewResult = (homeController.Subtract(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "X must be a number.");
        }

        [Test]
        public void Should_raise_vaildation_error_when_subtracting_where_Y_is_not_a_number()
        {
            // 1. Arrange

            double x = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = x.ToString(), Y = "bar" };

            // 2. Act

            var viewResult = (homeController.Subtract(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "Y must be a number.");
        }

        [Test]
        public void Should_multiply_two_numbers()
        {
            // 1. Arrange

            double x = 3;
            double y = 2;
            var result = (x * y);
            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var model = new CalculatorModel { X = x.ToString(), Y = y.ToString() };

            mockCalculator.Setup(c => c.Multiply(x, y)).Returns(result);

            // 2. Act

            var viewResult = (homeController.Multiply(model) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsNotNull(viewResult.Model);

            model = (viewResult.Model as CalculatorModel);

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Result, result.ToString());
        }

        [Test]
        public void Should_raise_vaildation_error_when_multiplying_where_X_is_not_a_number()
        {
            // 1. Arrange

            double y = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = "foo", Y = y.ToString() };

            // 2. Act

            var viewResult = (homeController.Multiply(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "X must be a number.");
        }

        [Test]
        public void Should_raise_vaildation_error_when_multiplying_where_Y_is_not_a_number()
        {
            // 1. Arrange

            double x = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = x.ToString(), Y = "bar" };

            // 2. Act

            var viewResult = (homeController.Multiply(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "Y must be a number.");
        }

        [Test]
        public void Should_divide_two_numbers()
        {
            // 1. Arrange

            double x = 3;
            double y = 2;
            var result = (x / y);
            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var model = new CalculatorModel { X = x.ToString(), Y = y.ToString() };

            mockCalculator.Setup(c => c.Divide(x, y)).Returns(result);

            // 2. Act

            var viewResult = (homeController.Divide(model) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsNotNull(viewResult.Model);

            model = (viewResult.Model as CalculatorModel);

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Result, result.ToString());
        }

        [Test]
        public void Should_raise_vaildation_error_when_dividing_where_X_is_not_a_number()
        {
            // 1. Arrange

            double y = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = "foo", Y = y.ToString() };

            // 2. Act

            var viewResult = (homeController.Divide(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "X must be a number.");
        }

        [Test]
        public void Should_raise_vaildation_error_when_dividing_where_Y_is_not_a_number()
        {
            // 1. Arrange

            double x = 3;

            var mockCalculator = new Mock<ICalculator>();
            var homeController = new HomeController(mockCalculator.Object);
            var calculatorModel = new CalculatorModel { X = x.ToString(), Y = "bar" };

            // 2. Act

            var viewResult = (homeController.Divide(calculatorModel) as ViewResult);

            // 3. Assert

            Assert.IsNotNull(viewResult);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual(viewResult.ViewData.ModelState.Count, 1);

            var modelState = viewResult.ViewData.ModelState.Values.First();

            Assert.AreEqual(modelState.Errors.Count, 1);
            Assert.AreEqual(modelState.Errors.First().ErrorMessage, "Y must be a number.");
        }
    }
}