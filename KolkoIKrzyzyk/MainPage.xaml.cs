using System;
using System.Collections;
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
        bool hasWinner = false;
        int roundsCounter = 0;
        
        public MainPage()
        {
            InitializeComponent();
        }

        public void DrawSymbol(object sender, EventArgs e)
        {
            Button field = sender as Button;

            if(String.IsNullOrWhiteSpace(field.Text) && !hasWinner && roundsCounter != 9)
            {
                roundsCounter++;

                field.Text = currentPlayer;

                if (currentPlayer == "×")
                {
                    lbl_playerIndicator.Text = "Teraz gra: ○";
                }
                else
                {
                    lbl_playerIndicator.Text = "Teraz gra: ×";
                }

                CheckForWinner();

                if (currentPlayer == "×")
                {
                    currentPlayer = "○";
                }
                else
                {
                    currentPlayer = "×";
                }
            }       
        }

        private void CheckForWinner()
        {
            if(lbl_R0_C0.Text == currentPlayer && lbl_R0_C1.Text == currentPlayer && lbl_R0_C2.Text == currentPlayer)
            {
                lbl_R0_C0.TextColor = Color.Blue;
                lbl_R0_C1.TextColor = Color.Blue;
                lbl_R0_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (lbl_R1_C0.Text == currentPlayer && lbl_R1_C1.Text == currentPlayer && lbl_R1_C2.Text == currentPlayer)
            {
                lbl_R1_C0.TextColor = Color.Blue;
                lbl_R1_C1.TextColor = Color.Blue;
                lbl_R1_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (lbl_R2_C0.Text == currentPlayer && lbl_R2_C1.Text == currentPlayer && lbl_R2_C2.Text == currentPlayer)
            {
                lbl_R2_C0.TextColor = Color.Blue;
                lbl_R2_C1.TextColor = Color.Blue;
                lbl_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }

            else if (lbl_R0_C0.Text == currentPlayer && lbl_R1_C0.Text == currentPlayer && lbl_R2_C0.Text == currentPlayer)
            {
                lbl_R0_C0.TextColor = Color.Blue;
                lbl_R1_C0.TextColor = Color.Blue;
                lbl_R2_C0.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (lbl_R0_C1.Text == currentPlayer && lbl_R1_C1.Text == currentPlayer && lbl_R2_C1.Text == currentPlayer)
            {
                lbl_R0_C1.TextColor = Color.Blue;
                lbl_R1_C1.TextColor = Color.Blue;
                lbl_R2_C1.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (lbl_R0_C2.Text == currentPlayer && lbl_R1_C2.Text == currentPlayer && lbl_R2_C2.Text == currentPlayer)
            {
                lbl_R0_C2.TextColor = Color.Blue;
                lbl_R1_C2.TextColor = Color.Blue;
                lbl_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            
            else if(lbl_R0_C2.Text == currentPlayer && lbl_R1_C1.Text == currentPlayer && lbl_R2_C0.Text == currentPlayer)
            {
                lbl_R0_C2.TextColor = Color.Blue;
                lbl_R1_C1.TextColor = Color.Blue;
                lbl_R2_C0.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (lbl_R0_C0.Text == currentPlayer && lbl_R1_C1.Text == currentPlayer && lbl_R2_C2.Text == currentPlayer)
            {
                lbl_R0_C0.TextColor = Color.Blue;
                lbl_R1_C1.TextColor = Color.Blue;
                lbl_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }

            if(hasWinner && roundsCounter <= 9)
            {
                ScoreSystem.AddPoint(currentPlayer);
                DisplayAlert("Koniec gry", "Wygrywa " + currentPlayer, "OK");
                lbl_score.Text = ScoreSystem.DrawScoreCounter();
                lbl_playerIndicator.Text = "Wygrał " + currentPlayer;

                return;
            }

            if (!hasWinner && roundsCounter == 9)
            {
                DisplayAlert("Koniec gry", "Remis", "OK");
                lbl_playerIndicator.Text = "Remis";

                return;
            }
        }

        public void NewRound(object sender, EventArgs e)
        {
            ResetRoundStaus();
        }

        public void ResetGame(object sender, EventArgs e)
        {
            ResetRoundStaus();

            ScoreSystem.ResetScore();

            lbl_score.Text = ScoreSystem.DrawScoreCounter();
        }

        private void ResetRoundStaus()
        {
            currentPlayer = "×";
            hasWinner = false;
            roundsCounter = 0;

            lbl_R0_C0.Text = "";
            lbl_R0_C1.Text = "";
            lbl_R0_C2.Text = "";
            lbl_R1_C0.Text = "";
            lbl_R1_C1.Text = "";
            lbl_R1_C2.Text = "";
            lbl_R2_C0.Text = "";
            lbl_R2_C1.Text = "";
            lbl_R2_C2.Text = "";

            lbl_R0_C0.TextColor = Color.Black;
            lbl_R0_C1.TextColor = Color.Black;
            lbl_R0_C2.TextColor = Color.Black;
            lbl_R1_C0.TextColor = Color.Black;
            lbl_R1_C1.TextColor = Color.Black;
            lbl_R1_C2.TextColor = Color.Black;
            lbl_R2_C0.TextColor = Color.Black;
            lbl_R2_C1.TextColor = Color.Black;
            lbl_R2_C2.TextColor = Color.Black;

            lbl_playerIndicator.Text = "Teraz gra: ×";
        }
    }
}
