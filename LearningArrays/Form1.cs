using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningArrays
{
    public partial class Form1 : Form
    {
        public Form1()// Our app will generate random menu for sandwiches
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() }; //Randomizer = new Random() is object initializer
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();

        }
    }
}
