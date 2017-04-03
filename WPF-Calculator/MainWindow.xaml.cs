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

        private void ClearMe()
        {
            inputOne.Text = "";
            inputTwo.Text = "";
        }

        private float FloatNumbers(string inputme)
        {
            float temp = 0;
            temp = float.Parse(inputme);
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
            firstly = FloatNumbers(inputOne.Text);
            secondly = FloatNumbers(inputTwo.Text);

            if (operate == "addMe")
            {
                answerini.Text = $"{firstly + secondly}";
            }
            else if (operate == "subtractMe")
            {
                answerini.Text = $"{firstly -= secondly}";
            }
            else if (operate == "multiplyMe")
            {
                answerini.Text = $"{firstly * secondly}";
            }
            else if (operate == "divideMe")
            {
                answerini.Text = $"{firstly / secondly}";
            }
            else if (operate == "percentMe")
            {
                answerini.Text = $"{(secondly / firstly) * 100}";
            }
            ClearMe();
        }

        private double memoryPlace = 0;

        private void MemoryButton(object sender, RoutedEventArgs e)
        {
            memoryPlace = FloatNumbers(inputOne.Text);
        }

        private void MemoryRecall(object sender, RoutedEventArgs e)
        {
            inputOne.Text = $"{memoryPlace}";
        }

        private void MemoryClear(object sender, RoutedEventArgs e)
        {
            memoryPlace = 0;
        }
    }
}
