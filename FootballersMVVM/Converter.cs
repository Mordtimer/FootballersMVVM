﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace FootballersMVVM.Converter {
    class Converter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            foreach(object value in values) {
                if((value is bool) && (bool)value == false) {
                    return false;
                }
            }
            return true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
