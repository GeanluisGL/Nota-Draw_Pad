using Principal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace OptionProg
{
    public partial class Prinp : Form
    {
        public Prinp()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            DcuRadio newPrin = new DcuRadio();
            newPrin.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            this.Hide();

            Note notewin = new Note();
            notewin.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Paintb paintwin = new Paintb();
            paintwin.Show();
        }

        private void Prinp_Load(object sender, EventArgs e)
        {

        }
    }
}
