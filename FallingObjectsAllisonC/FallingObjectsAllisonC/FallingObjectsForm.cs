/*
 * Created by: Allison Cook
 * Created on: 18 February, 2018
 * Created for: ICS3U Programming
 * Assignment 2 - falling Objects
 * This program takes user input of at what time to measure the height of an object falling from
 * a 100 meter cliff, as well as a second question where the user inputs the time as well as the
 * height of the cliff
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsAllisonC
{
    public partial class frmFallingObjects : Form
    {

        // local variables
        double time;
        double height;

        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //when Exit is clicked it will close the program
            this.Close();
        }

        private void mniQuestion1_Click(object sender, EventArgs e)
        {
            //Taking away unneeded information for question 1
            txtHeight.Visible = false;
            lblEnterHeight.Hide();
            lblAnswer.Hide();
        }

        private void mniQuestion2_Click(object sender, EventArgs e)
        {
            //displaying the additional information for question 2
            txtHeight.Visible = true;
            lblEnterHeight.Show();
            lblAnswer.Hide();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            //Checking which question it is by what is shown
            if (txtHeight.Visible == false)
            {                
                try
                {
                    time = double.Parse(txtTime.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input a number.");
                }
                //checking if the number is posistive
                if (time > 0)
                {
                    //using formual to find height
                    double Answer = (100 - 0.5 * 9.81 * Math.Pow(time, 2));
                    //rounding to two decimal places
                    Answer = Math.Round(Answer,2);
                    if (Answer > 0)
                    {
                        // Chaning the text to be the answer
                        lblAnswer.Text = Convert.ToString(Answer) + "Meters";

                    }
                    else
                    {
                        MessageBox.Show("At that time the object would have already hit the ground.");
                    }


                }
                //if the number is not positive then display message
                else
                {
                    MessageBox.Show("Please enter a positive number.");
                }


            }
            //Repeating but with two varriable for the second question
            else
            {
                //trying it stops from crashing the program
                try
                {
                    time = double.Parse(txtTime.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input a number for time.");
                }
                try
                {
                    height = int.Parse(txtHeight.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input a number for height.");
                }
                time = int.Parse(txtTime.Text);
                Height = int.Parse(txtHeight.Text);
                //checking if the number is posistive
                if (time > 0)
                {
                    if (height > 0)
                    {
                         //using formual to find height
                         double Answer = (height - 0.5 * 9.81 * Math.Pow(time, 2));
                        //rounding to two decimal places
                        Answer = Math.Round(Answer, 2);
                        if (Answer > 0)
                        {
                            // Chaning the text to be the answer
                            lblAnswer.Text = Convert.ToString(Answer) + "Meters";
                        }
                        else
                        {
                            MessageBox.Show("At that time the object would have already hit the ground.");
                        }
                    }
                }   //if the number is not positive then display message
                    else
                    {
                       MessageBox.Show("Please enter a positive number.");
                    } 
                    


            }
        }
    }
}


