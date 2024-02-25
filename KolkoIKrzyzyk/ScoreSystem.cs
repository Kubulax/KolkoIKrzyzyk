using System;
using System.Collections.Generic;
using System.Text;

namespace KolkoIKrzyzyk
{
    public static class ScoreSystem
    {
        private static int[] score = new int[2];

        public static void AddPoint(string player)
        {
            if (player == "×")
            {
                score[0] += 1;
            }
            else if (player == "○")
            {
                score[1] += 1;
            }
        }

        public static void ResetScore()
        {
            score = new int[2];
        }

        public static string DrawScoreCounter()
        {
            return "× " + score[0] + " : " + score[1] + " ○";
        }

    }
}
