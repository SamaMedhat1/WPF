using System.Data;
using System.Linq.Expressions;
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
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
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


        private void OnClick(object sender, RoutedEventArgs e)
        {
            string text = (sender as Button).Content.ToString();

            txt.Text += text;
        }

        private void OnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = txt.Text.Trim();
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");
                txt.Text = result.ToString();
            }
            catch
            {
                txt.Text = "";
                MessageBox.Show("Can't divide by zero");
            }
        }

        private void OnClick_Clear(object sender, RoutedEventArgs e)
        {
            txt.Text = string.Empty;
        }
    }
}