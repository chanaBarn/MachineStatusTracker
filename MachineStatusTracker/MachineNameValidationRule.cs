using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MachineStatusTracker
{
    public class MachineNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string machineName = value as string;

            if (string.IsNullOrWhiteSpace(machineName))
            {
                return new ValidationResult(false, "Machine name is required.");
            }

            return ValidationResult.ValidResult;
        }
    }
}
