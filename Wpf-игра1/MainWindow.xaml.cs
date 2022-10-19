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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_игра1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "A", "A",
                "B", "B",
                "C", "C",
                "D", "D",
                "🦖", "🦖",
                "🐍", "🐍",
                "🦐", "🦐",
                "🦆", "🦆",
            }; 
            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            { 
                int index = random.Next(animalEmoji.Count);
                string nextEmo = animalEmoji[index];
                textBlock.Text = nextEmo;
                animalEmoji.RemoveAt(index);
            }
            
 
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
