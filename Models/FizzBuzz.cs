using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), Range(1, 1000, ErrorMessage = "Oczekiwana wartość z zakresu {1} i {2}.")]
        public int Number { get; set; }

        public bool Fizz()
        {
            return Number % 3 == 0;

        }
        public bool Buzz()
        {
            return Number % 5 == 0;
        }

        public bool Fizzbuzz()
        {
            return Fizz() && Buzz();
        }
        public string IsDividable()
        {
            if (Fizzbuzz())
            {
                return "FizzBuzz";
            }
            if (Fizz())
            {
                return "Fizz";
            }
            if (Buzz())
            {
                return "Buzz";
            }
            return "Liczba " + Number + " nie spełnia kryteriów FizzBuzz";
        }
    }
}
