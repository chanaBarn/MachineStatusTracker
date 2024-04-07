using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MachineStatusTracker
{
    public class StatusValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string status = value as string;

            // Assume valid status values are "Running", "Idle", and "Offline"
            if (string.IsNullOrEmpty(status) || (status != "Running" && status != "Idle" && status != "Offline"))
            {
                return new ValidationResult(false, "Invalid status value.");
            }

            return ValidationResult.ValidResult;
        }
    }
}
