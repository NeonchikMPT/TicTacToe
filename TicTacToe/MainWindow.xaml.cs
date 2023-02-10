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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool playerIsCross, botTurn = false, gameIsGoing;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content == "" && gameIsGoing)
            {
                botTurn = true;
                if (playerIsCross)
                {
                    button.Content = "X";
                    button.Background = Brushes.Red;
                }
                else
                {
                    button.Content = "O";
                    button.Background = Brushes.Blue; 
                }
            }
            WinChecker();
            Bot();
            WinChecker();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = "TicTacToe";
            gameIsGoing = true;
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            button1.Background = Brushes.Transparent;
            button2.Background = Brushes.Transparent;
            button3.Background = Brushes.Transparent;
            button4.Background = Brushes.Transparent;
            button5.Background = Brushes.Transparent;
            button6.Background = Brushes.Transparent;
            button7.Background = Brushes.Transparent;
            button8.Background = Brushes.Transparent;
            button9.Background = Brushes.Transparent;
            playerIsCross = !playerIsCross;
            if (!playerIsCross)
            {
                botTurn = true;
                Bot();
            }
        }

        private void Bot()
        {
            int i = 0;
            while (botTurn && i < 1000 && gameIsGoing)
            {
                i++;
                switch (random.Next(1, 9))
                {
                    case 1:
                        if (button1.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button1.Content = "O";
                                button1.Background = Brushes.Blue;
                            }
                            else
                            {
                                button1.Content = "X";
                                button1.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 2:
                        if (button2.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button2.Content = "O";
                                button2.Background = Brushes.Blue;
                            }
                            else
                            {
                                button2.Content = "X";
                                button2.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 3:
                        if (button3.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button3.Content = "O";
                                button3.Background = Brushes.Blue;
                            }
                            else
                            {
                                button3.Content = "X";
                                button3.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 4:
                        if (button4.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button4.Content = "O";
                                button4.Background = Brushes.Blue;
                            }
                            else
                            {
                                button4.Content = "X";
                                button4.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 5:
                        if (button5.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button5.Content = "O";
                                button5.Background = Brushes.Blue;
                            }
                            else
                            {
                                button5.Content = "X";
                                button5.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 6:
                        if (button6.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button6.Content = "O";
                                button6.Background = Brushes.Blue;
                            }
                            else
                            {
                                button6.Content = "X";
                                button6.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 7:
                        if (button7.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button7.Content = "O";
                                button7.Background = Brushes.Blue;
                            }
                            else
                            {
                                button7.Content = "X";
                                button7.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 8:
                        if (button8.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button8.Content = "O";
                                button8.Background = Brushes.Blue;
                            }
                            else
                            {
                                button8.Content = "X";
                                button8.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                    case 9:
                        if (button9.Content == "")
                        {
                            if (playerIsCross)
                            {
                                button9.Content = "O";
                                button9.Background = Brushes.Blue;
                            }
                            else
                            {
                                button9.Content = "X";
                                button9.Background = Brushes.Red;
                            }
                            botTurn = false;
                        }
                        break;
                }
                
            }
            botTurn = false;
        }
        private void WinChecker()
        {
            gameIsGoing = false;
            if (button1.Content != "" && button2.Content != "" && button3.Content != "" && button4.Content != "" && button5.Content != "" && button6.Content != "" && button7.Content != "" && button8.Content != "" && button9.Content != "")
            {
                TextBlock.Text = "Ничья";
            }
            if (button1.Content == "X" && button2.Content == "X" && button3.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button4.Content == "X" && button5.Content == "X" && button6.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button7.Content == "X" && button8.Content == "X" && button9.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button1.Content == "X" && button4.Content == "X" && button7.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button2.Content == "X" && button5.Content == "X" && button8.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }   
            else if (button3.Content == "X" && button6.Content == "X" && button9.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button1.Content == "X" && button5.Content == "X" && button9.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button3.Content == "X" && button5.Content == "X" && button7.Content == "X")
            {
                TextBlock.Text = "Крестики победили";
            }
            else if (button1.Content == "O" && button2.Content == "O" && button3.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button4.Content == "O" && button5.Content == "O" && button6.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button7.Content == "O" && button8.Content == "O" && button9.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button1.Content == "O" && button4.Content == "O" && button7.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button2.Content == "O" && button5.Content == "O" && button8.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button3.Content == "O" && button6.Content == "O" && button9.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button1.Content == "O" && button5.Content == "O" && button9.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else if (button3.Content == "O" && button5.Content == "O" && button7.Content == "O")
            {
                TextBlock.Text = "Нолики победили";
            }
            else gameIsGoing = true;

        }
    }
}
