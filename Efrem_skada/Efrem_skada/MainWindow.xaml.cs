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

<<<<<<< HEAD
=======
        // ===== ЛОГИКА ДЛЯ КРАСНОЙ РАМКИ (+ / -) =====
>>>>>>> new_main
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
<<<<<<< HEAD
        private void MinusMinusButton_Копировать(object sender, RoutedEventArgs e)
        {
            if (currentValue > 0)
            {
                currentValue-10;
                UpdateDisplay();
            }
        }
    }
}
=======

        // ===== ОБЩИЙ МЕТОД ДЛЯ ОБРАБОТКИ КНОПОК ОТКРЫТ/ЗАКРЫТ =====
        private void SetButtonState(Button openBtn, Button closeBtn, bool isOpen)
        {
            if (isOpen)
            {
                openBtn.Background = Brushes.Green;
                closeBtn.Background = Brushes.White;
            }
            else
            {
                openBtn.Background = Brushes.White;
                closeBtn.Background = Brushes.Green;
            }
        }

        // ===== ПАРА 1 =====
        private void Pair1_Open_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair1_Open, Pair1_Close, true);
        }

        private void Pair1_Close_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair1_Open, Pair1_Close, false);
        }

        // ===== ПАРА 2 =====
        private void Pair2_Open_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair2_Open, Pair2_Close, true);
        }

        private void Pair2_Close_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair2_Open, Pair2_Close, false);
        }

        // ===== ПАРА 3 =====
        private void Pair3_Open_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair3_Open, Pair3_Close, true);
        }

        private void Pair3_Close_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair3_Open, Pair3_Close, false);
        }

        // ===== ПАРА 4 =====
        private void Pair4_Open_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair4_Open, Pair4_Close, true);
        }

        private void Pair4_Close_Click(object sender, RoutedEventArgs e)
        {
            SetButtonState(Pair4_Open, Pair4_Close, false);
        }
    }
}
>>>>>>> new_main
