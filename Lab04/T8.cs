using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    
    
        class Hockey
        {
            public string Name { get; set; }
            public int Games { get; set; }
            public int Wins { get; set; }
            public int Loses { get; set; }
            public int Points { get; set; }

            public Hockey()
            {

            }
            public Hockey(string name, int games, int wins, int loses, int points)
            {
                Name = name;
                Games = games;
                Wins = wins;
                Loses = loses;
                Points = points;
            }           

        }

        class NHL : Hockey
        {



            public NHL()
            {

            }
            public NHL(string name, int games, int wins, int loses, int points)
            {
                Name = name;
                Games = games;
                Wins = wins;
                Loses = loses;
                Points = points;
            }
            
                public override string ToString()
            {
                return "Team: " + Name + "\nGames: " + Games + "\nWins: " + Wins + "\nLoses: " + Loses + "\nPoints: " + Points + "\n";
            }
        }
        class Liiga : Hockey
        {



            public Liiga()
            {

            }
            public Liiga(string name, int games, int wins, int loses, int points)
            {
                Name = name;
                Games = games;
                Wins = wins;
                Loses = loses;
                Points = points;
            }

            public override string ToString()
            {
                return "Team: " + Name + "\nGames: " + Games + "\nWins: " + Wins + "\nLoses: " + Loses + "\nPoints: " + Points + "\n";
            }
        }
    
}

