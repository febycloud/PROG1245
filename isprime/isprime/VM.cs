using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isprime
{
    public class PropertyChangedBase : INotifyPropertyChanged //创建一个基类监听PropertyChange事件
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName) //建立一个函数当property有变化时更新event到新的状态
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }

   
    public class VM: PropertyChangedBase //建立viewmodel继承propertychange基类
    {
        private int targetNum;
        public int TargetNum //当targetnum的set有变化时更新状态
        {
            set { targetNum = value;OnPropertyChanged("TargetNum"); } 
            get { return targetNum; }
        }
    }
}
