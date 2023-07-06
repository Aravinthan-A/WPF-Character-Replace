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

namespace CharReplace
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = Replacestring(txtname.Text, 'V', 'A');
            txtresult.Text = result;
           
        }
        private String Replacestring(String Text, Char OldChar, Char Newchar)
        {
            int Count = txtinput.Text.ToCharArray().Length;
            if (Count == 1)
            {
                Char Input = Convert.ToChar(txtinput.Text);
            }
            else
            {
                lblinput.Content = "Error";
            }
            int Value = txtoutput.Text.ToCharArray().Length;
            if (Value == 1)
            {
                Char Output = Convert.ToChar(txtoutput.Text);
            }
            else
            {
                lbloutput.Content = "Error";
            }
            Char[] Best =Text.ToCharArray();
            int Bestlength = Best.Length;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Bestlength; i++)
            {
                if (Text[i] == OldChar)
                {
                    stringBuilder.Append(Newchar);
                }
                else
                {
                    stringBuilder.Append(Best[i].ToString());
                }
            }
            return stringBuilder.ToString();

        }
    }
}


