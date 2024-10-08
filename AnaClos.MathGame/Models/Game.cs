﻿namespace AnaClos.MathGame.Models
{
    public class Game
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public Game() { }
        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}, Date: {Date}";
        }

    }
}
