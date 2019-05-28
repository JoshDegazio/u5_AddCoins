/* Josh Degazio
 * Started on: 2019/05/26 
 * To add up canadian coins to provide a dollar amount.
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

namespace _182685_u5_AddCoins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Set globals
        private int lineCount;
        string[] input;
        int[] values = new int[0];

        //Set Values
        double toonie = 2;
        double loonie = 1;
        double quarter = .25;
        double dime = .10;
        double nickel = .05;
        //Output
        double output;

        //When the program is opened
        public MainWindow()
        {
            InitializeComponent();
            lineCount = 0;
            tB_Input.Text += "\n";
            tB_Input.SelectionStart = tB_Input.Text.Length;
            tB_Input.Focus();
        }

        //When the run button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sort_Input();
            Generate_Output();
        }

        //For every time a key is released
        private void tB_Input_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && lineCount == 0)
            {
                tB_Input.Text += "\nLoonies:\n";
                tB_Input.SelectionStart =
                tB_Input.Text.Length;
                lineCount++;
            }
            else if (e.Key == Key.Return && lineCount == 1)
            {
                tB_Input.Text += "\nQuarters:\n";
                tB_Input.SelectionStart =
                tB_Input.Text.Length;
                lineCount++;
            }
            else if (e.Key == Key.Return && lineCount == 2)
            {
                tB_Input.Text += "\nDimes:\n";
                tB_Input.SelectionStart =
                tB_Input.Text.Length;
                lineCount++;
            }
            else if (e.Key == Key.Return && lineCount == 3)
            {
                tB_Input.Text += "\nNickels:\n";
                tB_Input.SelectionStart =
                tB_Input.Text.Length;
                lineCount++;
            }
            else if (e.Key == Key.Return && lineCount == 4)
            {
                tB_Input.Text += "\nPress the 'run' button!";
                tB_Input.SelectionStart =
                tB_Input.Text.Length;
                lineCount++;
            }
        }

        //Sorts input so that values are easier to work with
        private void Sort_Input()
        {
            input = tB_Input.Text.Split('\n');
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Array.Resize(ref values, values.Length + 1);
                    int.TryParse(input[i], out values[j]);
                    j++;
                }
            }
        }

        //Generates output value to display to user
        private void Generate_Output()
        {
            output = (values[0] * toonie) + (values[1] * loonie) + (values[2] * quarter) + (values[3] * dime) + (values[4] * nickel);
            tB_Output.Text = "Total cost: $" + output.ToString();
        }

    }
}
