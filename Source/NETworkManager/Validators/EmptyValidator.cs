﻿using System.Globalization;
using System.Windows.Controls;

namespace NETworkManager.Validators
{
    public class EmptyValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrEmpty((string)value) ? new ValidationResult(false, Resources.Localization.Strings.FieldCannotBeEmpty) : ValidationResult.ValidResult;
        }
    }
}
