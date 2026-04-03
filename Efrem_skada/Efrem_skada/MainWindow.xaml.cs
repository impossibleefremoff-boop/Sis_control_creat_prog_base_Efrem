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

namespace Efrem_skada
{
    public partial class MainWindow : Window
    {
        private double currentValue = 0;

        public MainWindow()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentValue < 100)
            {
                currentValue++;
                UpdateDisplay();
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentValue > 0)
            {
                currentValue--;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            ValueText.Text = currentValue.ToString("0");
        }
    }
}
