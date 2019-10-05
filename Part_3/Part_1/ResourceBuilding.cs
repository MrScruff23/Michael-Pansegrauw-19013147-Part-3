﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class ResourceBuilding : Building
    {
        public enum ResourceType
        {
            Minerals,
            VespienGas
        }

        private string resourceType;
        private int resourcesGenerated = 0;
        private int resourcesPerRound;
        private int resourcesRemaining;
    /*
        public string ResourceType
        {
            get { return resourceType; }
        }
        public int ResourcesGenerated
        {
            get { return resourcesGenerated; }
        }
        public int ResourcesPerRound
        {
            get { return resourcesPerRound; }
        }
        public int ResourcesRemaining
        {
            get { return resourcesRemaining; }
        }
        */


        //resources per round has a default value incase no alternative value is given to resourcesPerRound
        public ResourceBuilding(int xPos, int yPos, int health, int team, int resourcesRemaining, int resourcesPerRound = 10) 
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.maxHealth = health;
            this.team = team;
            this.symbol = "R";
            this.resourcesRemaining = resourcesRemaining;
            this.resourcesPerRound = resourcesPerRound;
        }

        public override void Destroy()
        {
            if (health <= 0)
            {
                symbol = "D";
            }
        }

        public override string ToString()
        {
            string str = string.Format(
                    "Position (x, y): (" + xPos + ", " + yPos + ")" +
                    "\nHealth\\MaxHealth : " + health + "\\" + maxHealth +
                    "\nresources per round: " + resourcesPerRound +
                    "\nResources remaining: " + resourcesRemaining +
                    "\nResources Generated" + resourcesGenerated +
                    "\n + Team : " + (team + 1) + " + " +
                    "\nResource type: " + resourceType +
                    "\nSymbol: " + Symbol);
            return str;
        }

        public void GenerateResources() 
        {
            int Temp = resourcesGenerated;
            if (Health > 0)
            {
                if (resourcesRemaining >= resourcesPerRound)
                {
                    resourcesGenerated += resourcesPerRound;
                    resourcesRemaining -= resourcesPerRound;
                } else if (resourcesRemaining > 0)
                {
                    resourcesGenerated += resourcesRemaining;
                    resourcesRemaining = 0;
                }
            }
            Temp = resourcesGenerated - Temp; // indicates how many resources are accumulated during this phase
            Program.UI.ResourcesUpdate(Team, Temp);
        }
    }
}
