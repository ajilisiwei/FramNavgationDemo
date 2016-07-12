using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FramNavgationDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mainvmodel = new MainWindowViewModel();
            this.DataContext = mainvmodel;
            this.Loaded += ShangPinJiLuView_Loaded;
        }
        void ShangPinJiLuView_Loaded(object sender, RoutedEventArgs e)
        {
            this.FirstPageBtn.Command.Execute(this.FirstPageBtn.CommandParameter);
        }

    }
}
