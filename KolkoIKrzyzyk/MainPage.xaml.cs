using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KolkoIKrzyzyk
{
    public partial class MainPage : ContentPage
    {
        string currentPlayer = "×";
        public MainPage()
        {
            InitializeComponent();
        }

        public void DrawSymbol(object sender, EventArgs e)
        {
            Button field = sender as Button;

            field.Text = currentPlayer;
        }

        public void ResetRound(object sender, EventArgs e)
        {
            Button field = sender as Button;

            field.Text = currentPlayer;
        }

        public void ResetGame(object sender, EventArgs e)
        {
            Button field = sender as Button;

            field.Text = currentPlayer;
        }
    }
}
