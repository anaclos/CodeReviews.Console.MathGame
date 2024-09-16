using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaClos.MathGame.Models
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
