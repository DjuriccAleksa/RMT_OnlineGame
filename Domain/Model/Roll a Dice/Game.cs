﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Roll_a_Dice
{
    public class Game
    {
        private const int FinalScore = 50;

        public int CurrentScore { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public Game(int currentScore, int score1, int score2)
        {
            CurrentScore = currentScore;
            Score1 = score1;
            Score2 = score2;
        }
    }
}