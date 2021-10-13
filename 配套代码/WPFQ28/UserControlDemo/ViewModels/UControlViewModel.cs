using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlDemo.Models;

namespace UserControlDemo.ViewModels
{
    class UControlViewModel : INotifyPropertyChanged
    {
        public UControlViewModel()
        {
            UserInfo = new UserInfoModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private UserInfoModel m_userInfo;
        public UserInfoModel UserInfo
        {
            get { return m_userInfo; }
            set
            {
                if(m_userInfo != value)
                {
                    m_userInfo = value;
                    OnPropertyChanged("UserInfo");
                }               
            }
        }
    }
}
