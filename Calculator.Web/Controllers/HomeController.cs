using System.Web.Mvc;
using Calculator.Web.Models;

namespace Calculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Calculator calculator;

        public HomeController()
        {
            calculator = new Calculator();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Add(CalculatorModel model)
        {
            double x, y;

            if (double.TryParse(model.X, out x) == false)
                ModelState.AddModelError(nameof(model.X), "X must be a number.");

            if (double.TryParse(model.Y, out y) == false)
                ModelState.AddModelError(nameof(model.Y), "Y must be a number.");

            if (ModelState.IsValid)
                model.Result = calculator.Add(x, y).ToString();

            return View(model);
        }

        public ActionResult Subtract()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Subtract(CalculatorModel model)
        {
            double x, y;

            if (double.TryParse(model.X, out x) == false)
                ModelState.AddModelError(nameof(model.X), "X must be a number.");

            if (double.TryParse(model.Y, out y) == false)
                ModelState.AddModelError(nameof(model.Y), "Y must be a number.");

            if (ModelState.IsValid)
                model.Result = calculator.Subtract(x, y).ToString();

            return View(model);
        }

        public ActionResult Multiply()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Multiply(CalculatorModel model)
        {
            double x, y;

            if (double.TryParse(model.X, out x) == false)
                ModelState.AddModelError(nameof(model.X), "X must be a number.");

            if (double.TryParse(model.Y, out y) == false)
                ModelState.AddModelError(nameof(model.Y), "Y must be a number.");

            if (ModelState.IsValid)
                model.Result = calculator.Multiply(x, y).ToString();

            return View(model);
        }

        public ActionResult Divide()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Divide(CalculatorModel model)
        {
            double x, y;

            if (double.TryParse(model.X, out x) == false)
                ModelState.AddModelError(nameof(model.X), "X must be a number.");

            if (double.TryParse(model.Y, out y) == false)
                ModelState.AddModelError(nameof(model.Y), "Y must be a number.");

            if (ModelState.IsValid)
                model.Result = calculator.Divide(x, y).ToString();

            return View(model);
        }
    }
}