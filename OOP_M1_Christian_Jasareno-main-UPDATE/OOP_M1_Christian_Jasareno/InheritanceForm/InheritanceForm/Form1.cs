﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yearLevel;
            if (int.TryParse(Yearlvltxt.Text, out yearLevel))
            {
                
                InventoryManagement.AddItem(FName.Text, LName.Text, Sectiontxt.Text, yearLevel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid year level.");
            }

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
