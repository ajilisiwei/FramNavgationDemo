using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace FramNavgationDemo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }

        #region 导航命令
        private RelayCommand _navigationCmd;

        public RelayCommand NavigationCmd { get { return _navigationCmd ?? (_navigationCmd = new RelayCommand(NavigationFun)); } }

        private void NavigationFun(object para)
        {
            return;
        }
        #endregion

        private Dictionary<string, Tuple<BaseVModel, Action<object>, string>> dicNav= new Dictionary<string, Tuple<BaseVModel, Action<object>, string>>();

        private Page001VModel _page001VM = new Page001VModel();
        private Page002VModel _page002VM = new Page002VModel();
        private Page003VModel _page003VM = new Page003VModel();
        private Page004VModel _page004VM = new Page004VModel();
        private void Page001Model_load(object para) { _page001VM.InitializeData(); }
        private void Page002Model_load(object para) { _page002VM.InitializeData(); }
        private void Page003Model_load(object para) { _page003VM.InitializeData(); }
        private void Page004Model_load(object para) { _page004VM.InitializeData(); }


        public MainWindowViewModel()
        {
            dicNav.Add("P000001", new Tuple<BaseVModel, Action<object>, string>(_page001VM, Page001Model_load, "Views/Page001.xaml"));
            dicNav.Add("P000002", new Tuple<BaseVModel, Action<object>, string>(_page002VM, Page002Model_load, "Views/Page002.xaml"));
            dicNav.Add("P000003", new Tuple<BaseVModel, Action<object>, string>(_page003VM, Page003Model_load, "Views/Page003.xaml"));
            dicNav.Add("P000004", new Tuple<BaseVModel, Action<object>, string>(_page004VM, Page004Model_load, "Views/Page004.xaml"));
        }



        #region "NaviCmd"

        private RelayCommand _naviCmd;
        string navid = string.Empty;
        string oldnavid = string.Empty;

        public RelayCommand NaviCmd { get { return _naviCmd ?? (_naviCmd = new RelayCommand(NaviFun)); } }


        private static Frame frame = null;
        private void NaviFun(object para)
        {
            Dictionary<string, object> dic = para as Dictionary<string, object>;
            if (dic == null)
                return;
            try
            {
                if (frame == null)
                {
                    frame = dic["frame"] as Frame;
                    frame.Navigated += frame_Navigated;
                }
                string _navid = dic["navid"].ToString(); //避免不存在的导航，导致返回机制出错
                if (!dicNav.ContainsKey(_navid))//导航页不存在的时候
                    return;
                oldnavid = navid;
                navid = _navid;

                frame.NavigationService.Navigate(new Uri(dicNav[navid].Item3, UriKind.Relative));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            Frame frame = sender as Frame;
            Page page = frame.Content as Page;
            Action<object> ac = dicNav[navid].Item2;
            ac.Invoke(null);
            page.DataContext = dicNav[navid].Item1;
        }

        #endregion

            
    }
}
