using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        recipe adding = new recipe();
        private object textBoxName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public object captures { get; private set; }

        private void EnterTheRecipe_Click(object sender, RoutedEventArgs e)
        {

            captures.Visibility = Visibility.Hidden;
        }
        private void EnterTheRecipe_Click(object sender, RoutedEventArgs e)
        {
            if(recipes.Text != "" && NumberCultureSource.Text != "")
            {
                if(Regex.IsMatch(NumberCultureSource.Text, @"\d+$"))
                {
                    cap1.Visibility = Visibility.Hidden;
                    cap2.Visibility = Visibility.Visible;

                    Head.Content = "CAPTURING RECIPE DETAILS OF " +recipes.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Only digits are allowed");
                }
            }
            else
            {
                MessageBox.Show("Both field are required");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearAllData_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxName.Clear();
            textBoxName.Text = "";
        }
    }
}
