using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Member firstMember = new Member();

        private void btnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldin "+firstMember.Name);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: "+firstMember.Name+"\nAge: "+firstMember.Age+"\nHeight: "+firstMember.Height+"\nWeight: "+firstMember.Weight);
        }

        private void btnSearchByAge_Click(object sender, EventArgs e)
        {
            short age = Int16.Parse(txtAge.Text);
            if(age==firstMember.Age)
                txtAge.Text=firstMember.Name;
            else
                MessageBox.Show("No Member Found At This Age");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstMember.Name = "Ekin Anıl ÖZCAN";
            firstMember.Age = 25;
            firstMember.Weight = 83.5;
            firstMember.Height = 183;
        }
    }
}
