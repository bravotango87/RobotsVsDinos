using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsDino
{
    public class Robot
    { 
        
        //member variables (what it has)
        public string name;
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;

        //Constructor(spawner)
        public Robot()

        {
            name = "Robot";
            health = 100;
            powerLevel = 100;
            weapon = "laserGun";
            attackPower = 15;
        }
        //Member methods (what it does)
        public void AttackDinosaur(Robot robot, Dinosaur dinosaur)
        {
            dinosaur.health -= dinosaur.attackPower;
           

        }




    }






}

