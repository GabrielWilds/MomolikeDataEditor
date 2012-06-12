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

namespace MomolikeDataEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        private void Browse(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)this.DataContext).Browse();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)this.DataContext).Load();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)this.DataContext).Save();
        }

        private void AddAnimation(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)this.DataContext).AddAnimation();
        }
    }
}
