using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp21
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Animation.Storyboard sb = new System.Windows.Media.Animation.Storyboard();
            double left = grid.Margin.Left,
                top = grid.Margin.Top,
                right = grid.Margin.Right,
                bottom = grid.Margin.Bottom;
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
            thicknessAnimation.From = new Thickness(left, top, right, bottom);
            thicknessAnimation.To = new Thickness(left + 200, top + 50, right, bottom + 50);
            thicknessAnimation.Duration = new TimeSpan(0, 0, 0, 0, 500);
            System.Windows.Media.Animation.Storyboard.SetTarget(thicknessAnimation, grid);
            System.Windows.Media.Animation.Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin", new object[] { }));
            sb.Completed += Sb_Completed;
            sb.Children.Add(thicknessAnimation);
            sb.Begin();

        }

        private void Sb_Completed(object sender, EventArgs e)
        {
            System.Windows.Media.Animation.Storyboard sb = new System.Windows.Media.Animation.Storyboard();
            double left = grid.Margin.Left,
                top = grid.Margin.Top,
                right = grid.Margin.Right,
                bottom = grid.Margin.Bottom;
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
            thicknessAnimation.From = new Thickness(left, top, right, bottom);
            thicknessAnimation.To = new Thickness(left + 2000, top, right, bottom);
            thicknessAnimation.Duration = new TimeSpan(0, 0, 0, 0, 800);
            System.Windows.Media.Animation.Storyboard.SetTarget(thicknessAnimation, grid);
            System.Windows.Media.Animation.Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin", new object[] { }));
            sb.Children.Add(thicknessAnimation);
            sb.Begin();
        }
    }
}
