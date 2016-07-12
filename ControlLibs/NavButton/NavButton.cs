using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ControlLibs
{
    public class NavButton:Button
    {

        /// <summary>
        /// 导航id
        /// </summary>
        public string NavId
        {
            get { return (string)GetValue(NavIdProperty); }
            set { SetValue(NavIdProperty, value); }
        }

        public static readonly DependencyProperty NavIdProperty =
            DependencyProperty.Register("NavId", typeof(string), typeof(NavButton), null);

        
    }
}
