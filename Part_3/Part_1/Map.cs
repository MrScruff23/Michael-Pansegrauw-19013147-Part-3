using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    [Serializable]
    class Map
    {
        public Unit[,] map = new Unit[20, 20];
        public List<Unit> units = new List<Unit>();
        public List<ButtonUnit> unitButton = new List<ButtonUnit>();
        public List<ButtonBuilding> buildingButton = new List<ButtonBuilding>();
        private int xSize, ySize;

        public int XSize
        {
            get { return xSize; }
        }
        public int YSize
        {
            get { return ySize; }
        }

        Random rand = new Random();

        public Map(int numberOfBuildings, int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            map = new Unit[XSize, YSize];

            for (int i = 0; i < numberOfBuildings; i++)
            {
                AddBuilding(CreateBuilding(i % 2));
                CreateWizzard();
            }
            DisplayAll();
        }

        private void CreateWizzard()
        {
            
        }

        // Both the type of unit, as well as their X and Y position, should be randomised; 
        // Meelee: int xPos, int yPos, double maxHealth, double attack, int team
        // Ranged: int xPos, int yPos, double maxHealth, double attack, int team

        // method returns a unit after creating it and assigning valuse to it
        public Building CreateBuilding(int team)
        {
            int xPos = rand.Next(0, XSize);
            int yPos = rand.Next(0, YSize);
            while (true)
            {
                if (map[xPos, yPos] == null)
                {
                    break;
                }
                xPos = rand.Next(0, 20);
                yPos = rand.Next(0, 20);
            }

            if (rand.NextDouble() < 0.5) // deturmines whether a unit is a ranged unit or a meelee unit
            {
                return new FactoryBuilding(xPos, yPos, 500, team, 3);
            }
            else
            {
                return new ResourceBuilding(xPos, yPos, 500, team, 500);
            }
        }

        // displays the units onto the GUI
        public void DisplayAll()
        {
            Program.UI.grbMap.Controls.Clear();
            foreach (Button butt in buildingButton)
            {
                Program.UI.grbMap.Controls.Add(butt);
            }
        }

        void button_Click(object sender, System.EventArgs e)
        {
            ButtonUnit butt = sender as ButtonUnit;
            Program.UI.txtUnitInfo.Text = butt.Unit.ToString();
        }

        // updates the position of the unit so it doesnt need to update the entire GUI
        public void UpDatePosition()
        {
            int Ysize = Program.UI.grbMap.Height / YSize;
            int Xsize = Program.UI.grbMap.Width / XSize;

            for (int i = 0; i < unitButton.Count; i++)
            {
                unitButton[i].SetBounds(unitButton[i].Unit.XPos * Xsize , unitButton[i].Unit.YPos * Ysize , Xsize, Ysize);
                unitButton[i].Text = unitButton[i].Unit.Symbol;
                unitButton[i].Refresh();
            }
        }

        // CREATES A BUTTON AND ADDS THGE UNIT TO THE LIST OF UNIT BUTTONS
        public void AddUnit(Unit u)
        {
            int Ysize = Program.UI.grbMap.Height / YSize;
            int Xsize = Program.UI.grbMap.Width / XSize;

            unitButton.Add(new ButtonUnit(u));
            unitButton[unitButton.Count - 1].ForeColor = (unitButton[unitButton.Count - 1].Unit.Team == 0) ? Color.Blue : Color.Red;
            unitButton[unitButton.Count - 1].SetBounds(unitButton[unitButton.Count - 1].Unit.XPos * Xsize, unitButton[unitButton.Count - 1].Unit.YPos * Ysize, Xsize, Ysize);
            unitButton[unitButton.Count - 1].Click += Button_Clicked;

            Program.UI.grbMap.Controls.Add(unitButton[unitButton.Count - 1]);
        }

        // creates a button for a building that is added to the simulation
        public void AddBuilding(Building b)
        {
            int Ysize = Program.UI.grbMap.Height / YSize;
            int Xsize = Program.UI.grbMap.Width / XSize;

            buildingButton.Add(new ButtonBuilding(b));
            buildingButton[buildingButton.Count - 1].Text = buildingButton[buildingButton.Count - 1].Building.Symbol;
            buildingButton[buildingButton.Count - 1].ForeColor = (buildingButton[buildingButton.Count - 1].Building.Team == 0) ? Color.Blue : Color.Red;
            buildingButton[buildingButton.Count - 1].SetBounds(buildingButton[buildingButton.Count - 1].Building.XPos * Xsize, buildingButton[buildingButton.Count - 1].Building.YPos * Ysize, Xsize, Ysize);

            Program.UI.grbMap.Controls.Add(buildingButton[buildingButton.Count - 1]);
        }

        protected void Button_Clicked(object sender, EventArgs e)
        {
            string tostring = "";
            if (sender.GetType() == typeof(ButtonBuilding))
            {
                ButtonBuilding B = sender as ButtonBuilding;
                tostring = B.Building.ToString();
            } else if (sender.GetType() == typeof(ButtonUnit))
            {
                ButtonUnit B = sender as ButtonUnit;
                tostring = B.Unit.ToString();
            }
            Console.WriteLine(tostring);
            Program.UI.txtUnitInfo.Text = tostring;
        }
    }

    // class that alows a button to save which unit it is holding
    [Serializable]
    class ButtonUnit : Button {
        public Unit Unit;

        public ButtonUnit(Unit Unit)
        {
            this.Unit = Unit;
        }
    }

    // class that alows a button to save which building it is holding
    [Serializable]
    class ButtonBuilding : Button
    {
        public Building Building;

        public ButtonBuilding(Building b)
        {
            this.Building = b;
        }
    }
}
