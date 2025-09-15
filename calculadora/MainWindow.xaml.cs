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

namespace calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botn_Click(object sender, RoutedEventArgs e)
        {
           int n1 =(int.Parse(txt.Text));
           int n2 = (int.Parse(txt2.Text));
           
            lbl.Content = (n1 + n2).ToString();
        }
    }
}