using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FramNavgationDemo
{
    /// <summary>
    /// 导航转换
    /// </summary>
    public class NaviConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null || values.Count() == 0)
                return null;
            Dictionary<string, object> dic = new Dictionary<string, object>();
            for (int i = 0; i < values.Count(); i++)
            {
                string keyName = "value" + (i - 1).ToString();
                if (i == 0) keyName = "frame";
                if (i == 1) keyName = "navid";
                dic.Add(keyName, values[i]);
            }
            return dic;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
