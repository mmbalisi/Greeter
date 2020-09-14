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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarkJustine.Greeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> colors = new List<string>()
            {
                "Blue" ,
                "White" ,
                "Grey" ,
                "Red" ,
                "Black" ,
                "Green" ,
                "Yellow" ,
                "Pink" 
            };

            cboColors.ItemsSource = colors;
        }

        private void btnClick_Me_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFirstName.Text + " " + txtLastName.Text;
            MessageBox.Show("Hello " + fullName + ", good afternoon! Your favorite color is " + cboColors.SelectedItem);
        }
    }
}
