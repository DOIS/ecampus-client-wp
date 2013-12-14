﻿using System;
using System.Windows;
using System.Windows.Data;

namespace eCampus.Core.Converters
{
    public sealed class VisibilityOccupationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            if ((int)value==0)
            {
                return Visibility.Collapsed;
            }
            
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo language)
        {
            return (Visibility)value == Visibility.Collapsed ? 0 : 1;
        }
    }
}
