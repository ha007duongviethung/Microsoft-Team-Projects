﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Uwp.Core.Converter
{
    public class DateTimeToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTimeOffset dateTime = (DateTimeOffset)value;
            return dateTime.ToString("dd/MM/yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string str = (string)value;
            return DateTime.Parse(str);
        }
    }
}
