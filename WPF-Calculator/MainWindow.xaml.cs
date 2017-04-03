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

namespace WPF_Calculator
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

        private string operate = "Hello";
        private float firstly = 0;
        private float secondly = 0;

        private void ClearMe ()
        {
            inputOne.Text = "";
            inputTwo.Text = "";
        }

        private float FloatNumbers (string inputme)
        {
            float temp = 0;
            temp = float.Parse(inputme);
            firstly = temp;
            return temp;
        }

        private void AdditionButton(object sender, RoutedEventArgs e)
        {
            operate = "addMe";
        }


        private void subtractionButton(object sender, RoutedEventArgs e)
        {
            operate = "subtractMe";
        }

        private void multiplyButton(object sender, RoutedEventArgs e)
        {
            operate = "multiplyMe";

        }

        private void divisionButton(object sender, RoutedEventArgs e)
        {
            operate = "divideMe";

        }

        private void percentageButton(object sender, RoutedEventArgs e)
        {
            operate = "percentMe";

        }
        private void equalsButton(object sender, RoutedEventArgs e)
        {
            if (operate == "addMe")
            {
                firstly = FloatNumbers(inputOne.Text);
                secondly = FloatNumbers(inputTwo.Text);
                answerini.Text = $"{firstly + secondly}";
                ClearMe();
            }
            else if (operate == "subtractMe")
            {
                int firstly = 0;
                firstly = int.Parse(inputOne.Text);
                int secondly = 0;
                secondly = int.Parse(inputTwo.Text);
                answerini.Text = $"{firstly -= secondly}";
                ClearMe();
            }
            else if (operate == "multiplyMe")
            {
                int firstly = 0;
                firstly = int.Parse(inputOne.Text);
                int secondly = 0;
                secondly = int.Parse(inputTwo.Text);
                answerini.Text = $"{firstly * secondly}";
                ClearMe();
            }
            else if (operate == "divideMe")
            {
                float firstly = 0;
                firstly = float.Parse(inputOne.Text);
                float secondly = 0;
                secondly = float.Parse(inputTwo.Text);
                answerini.Text = $"{firstly / secondly}";
                ClearMe();
            }
            else if (operate == "percentMe")
            {
                float firstly = 0;
                firstly = float.Parse(inputOne.Text);
                float secondly = 0;
                secondly = float.Parse(inputTwo.Text);
                answerini.Text = $"{(secondly / firstly)*100}";
                ClearMe();
            }
        }
    }
}
