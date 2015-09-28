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

namespace WpfApplication1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*int[] arrInt = new int[] { 1, 5, 8, 3, 9, 2 };

            for (int i = 0; i < 5; i++)
            {
                outPut("ForLoop: " + i + Environment.NewLine);
            }

            foreach (int item in arrInt)
            {
                outPut("ForEach: " + item + Environment.NewLine);
            }*/

            /*char[] charArray = {'H', 'e', 'l', 'l', 'o'};
            string charString = new string(charArray);
            outPut("This is " + charString);*/
        }

        private void outPut(string value)
        {
            outputText.Text += value;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            outputText.Text = "";
        }
    }
}
