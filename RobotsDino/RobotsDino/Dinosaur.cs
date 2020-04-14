using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsDino
{
    public class Dinosaur
    {
        //member variables (what it has)
        public string name;
        public int health;
        public bool energy;
        public int attackPower;
        //Constructor(spawner)
        public Dinosaur()
        {
                
                name = "Dinosaur";
                health = 100;
                energy = true;
                attackPower = 90;
        }
        //Member methods (what it does)
        public void AttackRobot(Dinosaur dinosaur, Robot robot)//what objects will 
=>      
        robot.health -= dinosaur.attackPower;
        public void LoseEnergy(Dinosaur dinosaur, Robot robot)
        {
            robot.attackPower -= dinosaur.attackPower;
        }

        public void LoseHealth(Dinosaur dinosaur, Robot robot)
        {
            robot.attackPower -= dinosaur.health;

        }
        

        


        
        
       
           


            
            

        }
     

     
        
    }
    
    

    
    
     
        
    

      
        
     

    



    
    

   



    

