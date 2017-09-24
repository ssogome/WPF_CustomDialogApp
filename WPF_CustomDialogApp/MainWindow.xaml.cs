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

namespace WPF_CustomDialogApp
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
     

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            TestCustomInputWindow inputDialog = new TestCustomInputWindow("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true)
                lblName.Text = inputDialog.Answer;
        }      
    }
}
