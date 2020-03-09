using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAbstract
{
    abstract class Player
    {
        protected string name;
        protected string teamName;
        protected int noOfMatches;
        public string Name { get => name; set => name = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public int NoOfMatches { get => noOfMatches; set => noOfMatches = value; }
        public Player(string name, string teamName,int noOfMatches)
        {
            this.Name = name;
            this.TeamName = teamName;
            this.NoOfMatches = noOfMatches;
        }
        public abstract void DisplayPlayerStatistics();
       
    }
    class CricketPlayer : Player 
    {
        int totalruns, no_of_wickets;
        public int Totalruns { get => totalruns; set => totalruns = value; }
        public int No_of_wickets { get => no_of_wickets; set => no_of_wickets = value; }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("Player Name:"+this.name+"\nTeam Name:"+this.teamName+"\nNo Of Matches"+ this.noOfMatches +"\nTotal Runs Scored:"+ this.totalruns +"\nTotal Wickets Taken:"+ this.no_of_wickets);
        }
        public CricketPlayer(string name, string teamName, int noOfMatches,int runs,int wickets):base(name,teamName,noOfMatches)
        {
            this.totalruns = runs;
            this.no_of_wickets = wickets;
            Console.WriteLine("Cricket Player Consructor");
        }
    }
    class HockeyPlayer : Player
    {
        string position;
        int NoOfGoals;
        public HockeyPlayer(string name, string teamName, int noOfMatches,string position, int noOfGoals):base(name, teamName, noOfMatches)
        {
            this.position = position;
            this.NoOfGoals = noOfGoals;
            Console.WriteLine("Hockey Player Consructor");
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("Player Name:" + this.name + "\nTeam Name:" +this. teamName + "\nNo Of Matches" + this.noOfMatches + "\nTotal Runs Scored:" + this.position + "\nTotal GoalsTaken:"+this.NoOfGoals);
        }
    }
}
