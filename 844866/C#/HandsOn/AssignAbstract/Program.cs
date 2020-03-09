using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Cricket Player Details\n 2.Hockey Player Deatils\n");
            Console.WriteLine("Enter Choice\n");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter player name\n");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter team name\n");
                    string teamname = Console.ReadLine();
                    Console.WriteLine("Enter number of matches played\n");
                    int noofmatches = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter total number of Runs Scored\n");
                    int runs = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter totoal number of Wickets taken\n");
                    int wickets = int.Parse(Console.ReadLine());
                    CricketPlayer c = new CricketPlayer(name,teamname,noofmatches,runs,wickets);
                    Console.WriteLine("Player Details.\n");
                    c.DisplayPlayerStatistics();
                    break;
                case 2:
                    Console.WriteLine("Enter player name\n");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter team name\n");
                    string teamName = Console.ReadLine();
                    Console.WriteLine("Enter number of matches played\n");
                    int noofMatches = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Position\n");
                    string position = Console.ReadLine();
                    Console.WriteLine("Enter totoal number of Goals taken\n");
                    int noofgoals = int.Parse(Console.ReadLine());
                    HockeyPlayer h = new HockeyPlayer(Name, teamName, noofMatches, position, noofgoals);
                    Console.WriteLine("Player Details.\n");
                    h.DisplayPlayerStatistics();
                    break;
            }
             Console.ReadLine();

        }
    }
}
