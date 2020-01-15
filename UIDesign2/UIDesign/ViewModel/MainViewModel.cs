using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using UIDesign.Entity;

namespace UIDesign.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            InitUserModuleBar();
        }

        public ObservableCollection<UserModule> UserModules { get; set; }

        public void InitUserModuleBar()
        {
            UserModules = new ObservableCollection<UserModule>();
            UserModules.Add(new UserModule() { FilePath = "Images/Image1.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image2.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image3.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image4.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image5.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image6.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image7.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModules.Add(new UserModule() { FilePath = "Images/Image8.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
        }
    }
}