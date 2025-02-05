﻿using System;
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
using System.Windows.Shapes;
using _12._1.BL;
using _12._1.ViewControl;

namespace _12._1
{
    /// <summary>
    /// Логика взаимодействия для TopUpWindow.xaml
    /// </summary>
    public partial class TopUpWindow : Window
    {
        MainWindow mainWindow;
        public TopUpWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void EnterAmountTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((e.Text[0] < '0' || e.Text[0] > '9') && e.Text[0] != '.')
            {
                e.Handled = true;
            }
        }

        private void TopUpButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.employee.TopUpAccount(mainWindow.AccountsListView.SelectedItem as Account, double.Parse(enterAmountTextBox.Text));
            Close();
        }

    }
}
