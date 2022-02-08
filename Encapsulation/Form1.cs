using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static List<Student> students = new List<Student>()
        {
            new Student("Ekin",74.2),
            new Student("Mahir",75.5),
            new Student("Enes",100),
            new Student("Ali",10),
        };

        private void btnOk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Sınav s= new Sınav();
            try
            {
                s.GeçmeNotu = Convert.ToDouble(txtGecmeNotu.Text);
            }
            catch (FormatException fe)
            {

                MessageBox.Show(fe.Message);
            }
            foreach (Student student in students)
            {
                if (student.Not >= s.GeçmeNotu)
                    listBox1.Items.Add(student.Name + " " + student.Not + " " + s.Name + " Sınavında Başarılı");
                else
                    listBox1.Items.Add(student.Name + " " + student.Not + " " + s.Name + " Sınavında Başarısız");
            }
            
        }
    }
}
