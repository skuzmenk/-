using System;
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

namespace натисниТАК
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonNo_MouseEnter(object sender, MouseEventArgs e)
        {
            double newX = random.Next(0, (int)(this.ActualWidth - ButtonNo.ActualWidth-20));
            double newY = random.Next(0, (int)(this.ActualHeight - ButtonNo.ActualHeight-40));
            ButtonNo.Margin = new Thickness(newX, newY, 0, 0);
        }
        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дякую)))", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; 
        }
    }
}