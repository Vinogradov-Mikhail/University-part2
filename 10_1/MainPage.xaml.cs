using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace _10_1
{
    /// <summary>
    /// Main program class
    /// </summary>
    public partial class MainPage : UserControl
    {
        private readonly Button[] buttons;

        /// <summary>
        /// Initialization 
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            buttons = new Button[9];
            buttons[0] = _11;
            buttons[1] = _12;
            buttons[2] = _13;
            buttons[3] = _21;
            buttons[4] = _22;
            buttons[5] = _23;
            buttons[6] = _31;
            buttons[7] = _32;
            buttons[8] = _33;
        }

        /// <summary>
        /// method for players click on button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayersMove(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            setBitten(button, "X");
            if (!AllDisabled())
            {
                setBitten(RandomButton(), "O");
            }
        }

        /// <summary>
        /// find random number of button from free buttons
        /// </summary>
        /// <returns></returns>
        private Button RandomButton()
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            var randInt = rand.Next(0, 9);
            while (!buttons[randInt].IsEnabled)
            {
                randInt = rand.Next(0, 9);
            }
            return buttons[randInt];
        }

        /// <summary>
        /// checking all buttons is disabled
        /// </summary>
        /// <returns></returns>
        private bool AllDisabled()
        {
            for (int i = 0; i < 9; ++i)
            {
                if (buttons[i].IsEnabled)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// checking board for finding wininig line
        /// </summary>
        /// <param name="player"></param>
        private void WinCheck(string player)
        {
            System.Func<int, bool> chek = i => buttons[i].Content.ToString() == player;
            if ((chek(0) && chek(1) && chek(2))
                || (chek(3) && chek(4) && chek(5))
                || (chek(6) && chek(7) && chek(8))
                || (chek(0) && chek(3) && chek(6))
                || (chek(1) && chek(4) && chek(7))
                || (chek(2) && chek(5) && chek(8))
                || (chek(0) && chek(4) && chek(8))
                || (chek(2) && chek(4) && chek(8)))
            {
                foreach (var button in buttons)
                {
                    button.IsEnabled = false;
                }
                buttons[4].Content = "Player " + player + " win";
            }
            else
            {
                if (AllDisabled())
                {
                    buttons[4].Content = "Draw";
                }
            }
        }

        /// <summary>
        /// method for checkin button text 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="player"></param>
        private void setBitten(Button button, string player)
        {
            button.Content = player;
            button.IsEnabled = false;
            WinCheck(player);
        }
    }
}
