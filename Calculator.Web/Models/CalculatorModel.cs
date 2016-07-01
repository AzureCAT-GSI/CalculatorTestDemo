using System.ComponentModel.DataAnnotations;

namespace Calculator.Web.Models
{
    public class CalculatorModel
    {
        [Required]
        public string X { get; set; }

        [Required]
        public string Y { get; set; }

        public string Result { get; set; }
    }
}