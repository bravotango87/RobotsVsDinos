using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsDino
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleField field = new BattleField();
            field.AttackRobot(60, 90);
            field.AttackDinosaur(100, 15);
            field.AttackDinosaur(75, 15);
            field.AttackRobot(80, 50);
            field.AttackRobot(70, 30);
        }
        public BattleField field = new BattleField();
        



 
           



        } 

    }



















