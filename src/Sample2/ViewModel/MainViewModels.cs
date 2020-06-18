using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIDesign.View;

namespace UIDesign.ViewModel
{
    public class MainViewModels : ViewModelBase
    {
        public MainViewModels()
        {
            openCommand = new RelayCommand<string>(t => OpenPage(t));
        }

        public RelayCommand<string> openCommand { get; private set; }

        private object page;

        public object Page
        {
            get { return page; }
            set { page = value; RaisePropertyChanged(); }
        }


        public void OpenPage(string type)
        {
            switch (type)
            {
                case "1": Page = new Page1(); break;
                case "2": Page = new Page3(); break;
            }
        }
    }
}
