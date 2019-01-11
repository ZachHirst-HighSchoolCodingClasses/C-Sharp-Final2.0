﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Timers;

namespace memeClicker
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public double[] MultiplierArray = { 1.1, 1.5, 2.1, 6.5, 14.3, 18.6, 23.4, 33.1, 48.9, 56.7};
        public double balance = 0;
        public int ticktimer = 1, timerupgrade;
        public int tick1 = 1, tick2 = 1, tick3 = 1, tick4 = 1, tick5 = 1, tick6 = 1, tick7 = 1, tick8 = 1, tick9 = 1, tick10 = 1;
        public double upgradestrength = 0;

        private void timerbuy_Click(object sender, EventArgs e)
        {
            if(balance < 200)
            {

            }
            else if(balance >= 200)
            {
                // Create a timer and set a five second interval.
                aTimer = new System.Timers.Timer();
                aTimer.Interval = 5000;

                // Hook up the Elapsed event for the timer. 
                aTimer.Elapsed += OnTimedEvent;

                // Have the timer fire repeated events (true is the default)
                aTimer.AutoReset = true;

                // Start the timer
                aTimer.Enabled = true;

                balance -= 200; //cost of timer
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            ++ticktimer;
            timerupgrade = ticktimer * 50; //number of upgrades multiplied by 50
            lbltimer.Text = "At time " + e.SignalTime + " " + timerupgrade + " points were added. \n"; //labeling the time
            balance = balance + timerupgrade; //50 points per 5 seconds
            lblNumber.Text = "" + balance; //labeling the points
            lbltimerupgrade.Text = "Multiplier: " + timerupgrade;
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //removes border
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balance++;
            lblNumber.Text = "" + balance;
            balance = upgradestrength + balance;
            lblmultiplier.Text = "Multiplier = " + upgradestrength;

            if (balance >= 10 && balance < 100)
            {
                pictureBox3.Visible = false;
                meme1.Visible = true;
                lblmeme1.Visible = true;
            }
            else if(balance >= 100 && balance < 1000)
            {
                pictureBox4.Visible = false;
                meme2.Visible = true;
                lblmeme2.Visible = true;
            }
            else if(balance >= 1000 && balance < 10000)
            {
                pictureBox6.Visible = false;
                meme3.Visible = true;
                lblmeme3.Visible = true;
            }
            else if(balance >= 10000 && balance < 100000)
            {
                pictureBox8.Visible = false;
                meme4.Visible = true;
                lblmeme4.Visible = true;
            }
            else if(balance >= 100000 && balance < 500000)
            {
                pictureBox10.Visible = false;
                meme5.Visible = true;
                lblmeme5.Visible = true;
            }
            else if(balance >= 500000 && balance < 1000000)
            {
                pictureBox12.Visible = false;
                meme6.Visible = true;
                lblmeme6.Visible = true;
            }
        }

        private void meme1_Click(object sender, EventArgs e)
        {
           if(balance < 10)
            {

            }
           else if(balance >= 10 && tick1 < 6)
            {
               
                    upgradestrength += (MultiplierArray[0] * tick1);
                    ++tick1;
                    balance -= 10;
                    lblNumber.Text = "" + balance;
                    lblmeme1.Text = "Upgrade: " + (tick1 - 1);
                
            }
        }

        private void meme2_Click(object sender, EventArgs e)
        {
            if(balance < 100)
            {

            }
            else if(balance >= 100 && tick2 < 6)
            {
                upgradestrength += (MultiplierArray[1] * tick2);
                ++tick2;
                balance -= 100;
                lblNumber.Text = "" + balance;
                lblmeme2.Text = "Upgrade: " + (tick2 - 1);
            }
        }

        private void meme3_Click(object sender, EventArgs e)
        {
            if(balance < 1000)
            {

            }
            else if(balance >= 1000 && tick3 < 6)
            {
                upgradestrength += (MultiplierArray[2] * tick3);
                ++tick3;
                balance -= 1000;
                lblNumber.Text = "" + balance;
                lblmeme3.Text = "Upgrade: " + (tick3 - 1);
            }
        }

        private void meme4_Click(object sender, EventArgs e)
        {
            if (balance < 10000)
            {

            }
            else if (balance >= 10000 && tick4 < 6)
            {
                upgradestrength += (MultiplierArray[3] * tick4);
                ++tick4;
                balance -= 10000;
                lblNumber.Text = "" + balance;
                lblmeme4.Text = "Upgrade: " + (tick4 - 1);
            }
        }

        private void meme5_Click(object sender, EventArgs e)
        {
            if (balance < 100000)
            {

            }
            else if (balance >= 100000 && tick5 < 6)
            {
                upgradestrength += (MultiplierArray[4] * tick5);
                ++tick5;
                balance -= 100000;
                lblNumber.Text = "" + balance;
                lblmeme5.Text = "Upgrade: " + (tick5 - 1);
            }
        }

        private void meme6_Click(object sender, EventArgs e)
        {
            if (balance < 500000)
            {

            }
            else if (balance >= 500000 && tick6 < 6)
            {
                upgradestrength += (MultiplierArray[5] * tick6);
                ++tick6;
                balance -= 100000;
                lblNumber.Text = "" + balance;
                lblmeme6.Text = "Upgrade: " + (tick6 - 1);
            }
        }
    }
}