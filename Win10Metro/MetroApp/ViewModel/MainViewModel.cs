using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MetroApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            MetroInfos = new ObservableCollection<MetroInfo>();

            kinds = new List<TransitionEffectKind>();
            kinds.Add(TransitionEffectKind.ExpandIn);
            kinds.Add(TransitionEffectKind.FadeIn);
            kinds.Add(TransitionEffectKind.SlideInFromLeft);
            kinds.Add(TransitionEffectKind.SlideInFromTop);
            kinds.Add(TransitionEffectKind.SlideInFromRight);
            kinds.Add(TransitionEffectKind.SlideInFromBottom);

            #region ÑÕÉ«

            colors = new List<string>();
            colors.Add("#FF8C69");
            colors.Add("#FF8247");
            colors.Add("#FF7256");
            colors.Add("#FF6347");
            colors.Add("#FFA07A");
            colors.Add("#FF82AB");
            colors.Add("#FF7F00");
            colors.Add("#FF69B4");
            colors.Add("#FFA500");
            colors.Add("#FF83FA");
            colors.Add("#FF7F24");
            colors.Add("#FF6A6A");
            colors.Add("#FFA54F");
            colors.Add("#FF8C00");
            colors.Add("#FF7F50");
            colors.Add("#FF6EB4");
            colors.Add("#00CED1");
            colors.Add("#00C5CD");
            colors.Add("#008B8B");
            colors.Add("#00688B");
            colors.Add("#00E5EE");
            colors.Add("#00CD00");
            colors.Add("#009ACD");
            colors.Add("#00868B");
            colors.Add("#00EE00");
            colors.Add("#00CD66");
            colors.Add("#00B2EE");
            colors.Add("#008B00");
            colors.Add("#00EE76");
            colors.Add("#00CDCD");
            colors.Add("#00BFFF");
            colors.Add("#008B45");
            colors.Add("#87CEFF");
            colors.Add("#858585");
            colors.Add("#838B83");
            colors.Add("#7FFF00");
            colors.Add("#7D7D7D");
            colors.Add("#87CEFA");
            colors.Add("#848484");
            colors.Add("#836FFF");
            colors.Add("#7F7F7F");
            colors.Add("#7D26CD");
            colors.Add("#87CEEB");
            colors.Add("#8470FF");
            colors.Add("#828282");
            colors.Add("#7EC0EE");
            colors.Add("#7CFC00");
            colors.Add("#878787");
            colors.Add("#838B8B");
            colors.Add("#7FFFD4");
            colors.Add("#7D9EC0");
            colors.Add("#7CCD7C");
            #endregion

            RefCommand = new RelayCommand(async () =>
              {
                  MetroInfos.Clear();
                  for (int i = 0; i < 30; i++)
                  {
                      MetroInfos.Add(new MetroInfo()
                      {
                          Name = "Ó¦ÓÃ" + i,
                          Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colors[new Random().Next(0, 51)])),
                          Width = new Random().Next(0, 8) == 3 ? 206 : 100,
                          Height = 100,
                          Effact = new TransitionEffect()
                          {
                              Kind = kinds[new Random().Next(2, 6)],
                              Duration = new TimeSpan(0, 0, 0, 0, 900)
                          }
                      });
                      await Task.Delay(10);
                  }
              });
        }

        public RelayCommand RefCommand { get; set; }

        public List<TransitionEffectKind> kinds;

        public List<string> colors;

        public ObservableCollection<MetroInfo> metroInfos;

        public ObservableCollection<MetroInfo> MetroInfos
        {
            get { return metroInfos; }
            set { metroInfos = value; RaisePropertyChanged(); }
        }
    }

    public class MetroInfo
    {
        public string Name { get; set; }

        public Brush Color { get; set; }

        public TransitionEffect Effact { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}