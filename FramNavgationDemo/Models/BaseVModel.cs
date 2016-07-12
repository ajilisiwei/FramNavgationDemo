using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FramNavgationDemo
{
    public class BaseVModel : INotifyPropertyChanged, IDisposable
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

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose() { }

        public virtual void InitializeData(){ }
    }
}
