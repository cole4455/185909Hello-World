/* Cole Stevens
 * Feb 6, 2019
 * Hello World My First Program
 */

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

namespace _185909HelloWorld
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

        private void btngreeting_Click(object sender, RoutedEventArgs e)
        {
            //What I type here will show up when button is pressed
            string Name = txtname.Text;
            Message.Content = "Hello, " + Name;

        }
    }
}
