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
            field.AttackRobot(100, 90);
            field.AttackDinosaur(100, 15);
            field.AttackDinosaur(100, 15);
        }

    }

    
   
}
