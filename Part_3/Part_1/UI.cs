using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    [Serializable]
    public partial class UI : Form
    {
        public int rounds = 0; // variable to keep track of the number of rounds that have passed
        // variables to keep track of the amount of resources 
        private int team1resources = 0;
        private int team2resources = 0;
        public bool start = false, xReady = false, yReady = false;


        public UI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, EventArgs e) // When the stop button is clicked the timer will bet stopped to stop the animation
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e) // each tick of the timer will triger a 'round' in the game engine 
        {
            GameEngine.Round();
        }

        private void BtnStart_Click(object sender, EventArgs e) // When the start button is clicked the timer will bet resumed to resume the animation
        {
            if (yReady == true && xReady == true)
            {
                timer1.Enabled = true;
                txtXSize.Visible = false;
                txtYSize.Visible = false;
                lblXSize.Visible = false;
                lblYSize.Visible = false;
                if (start == false)
                {
                    GameEngine.SetMapSize(Convert.ToInt32(txtXSize.Text), Convert.ToInt32(txtYSize.Text));
                    start = true;
                }
            }
        }

        public void RoundUpdate(int rounds) // updates the number of rounds that have passed
        {
            this.rounds = rounds;
            lblRound.Text = "Round: " + rounds;
        }

        // updates the display of the amount of resources and the variable that keep tracks of the resources
        public void ResourcesUpdate(int team, int resources)
        {
            if (team == 0)
            {
                team1resources += resources;
                lblTeam1resources.Text = "Team 1 resources: " + team1resources;
            }
            else if (team == 1)
            {
                team2resources += resources;
                lblTeam2resources.Text = "Team 2 resources: " + team2resources;
            }
        }

        // getting of team resource
        public int GetResources (int team)
        {
            return (team == 0) ? team1resources: team2resources;
        }

        // calls save method for the game
        private void btnSave_Click(object sender, EventArgs e)
        {
            GameEngine.Save();
        }

        // calls load method for the game
        private void btnLoad_Click(object sender, EventArgs e)
        {
            GameEngine.Load();
        }

        // ignore
        private void grbMap_Enter(object sender, EventArgs e)
        {

        }

        // validates the input of the text box
        private void txtYSize_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled != true)
                try
                {
                    yReady = false;
                    int i = Convert.ToInt32(txtYSize.Text);
                    if (i >= 5 && i <= 50 && txtYSize.Text.Length > 0)
                    {
                        txtYSize.BackColor = Color.LightGreen;
                        txtUnitInfo.Text = "";
                        yReady = true;
                    }
                    else
                    {
                        txtYSize.BackColor = Color.LightPink;
                        if (timer1.Enabled != true)
                        {
                            txtUnitInfo.Text = "y map size is not with in the range of 5 to 50";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    txtUnitInfo.Text = "The value entered is unusable";
                    txtYSize.BackColor = Color.LightPink;
                }
        }

        // validates the input of the text box
        private void txtXSize_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled != true)
                try
                {
                    xReady = false;
                    int i = Convert.ToInt32(txtXSize.Text);
                    if (i >= 5 && i <= 50 && txtXSize.Text.Length > 0)
                    {
                        txtXSize.BackColor = Color.LightGreen;
                        txtUnitInfo.Text = "";
                        xReady = true;
                    }
                    else
                    {
                        txtXSize.BackColor = Color.LightPink;
                        if (timer1.Enabled != true)
                        {
                            txtUnitInfo.Text = "X map size is not with in the range of 5 to 50";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    txtUnitInfo.Text = "The value entered is unusable";
                    txtXSize.BackColor = Color.LightPink;
                }
        }
    }
}
