using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Attributes
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;

            DateTime date = (DateTime)value;
            //return date > DateTime.Now;
            return date.ToUniversalTime() > DateTime.UtcNow;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"The {name} must be a future date and time.";
        }

    }
}
