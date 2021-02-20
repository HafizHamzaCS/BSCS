using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace racing_car_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int speed=""; 

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 3;

        }

        private void RoadMover(object sender, EventArgs e)
        {

        }
    }
}
