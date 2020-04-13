using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsDino
{
    public class BattleField
    {
        public bool AttackRobot(int healthPower, int attackPower)
        {
            int healthLevel = 100;
            int attackLevel = 90;

            if(healthPower >= healthLevel && attackPower >= attackLevel)
            {
                Console.WriteLine("Dinosaur Wins The Round");
                return true;
            }
            else if (healthPower <= healthLevel)
            {
                Console.WriteLine("Robot Wins The Round");
                return false;
            }
            else
            {
                Console.WriteLine("No Winner This Round!");
                return false;
            }
        }

        public bool AttackDinosaur(int healthPower, int attackPower)
        {
            int healthLevel = 100;
            int attackLevel = 15;

            if(healthPower >= healthLevel && attackPower >= attackLevel)
            {
                Console.WriteLine("Robot Wins The Round");
                return true;
            }
            else if (healthPower <= healthLevel)
            {
                Console.WriteLine("Dinosaur Wins The Round");
                return false;
            }
            else
            {
                Console.WriteLine("No Winner This Round!");
                return false;
            }

        }



    }
}
