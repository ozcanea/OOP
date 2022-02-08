using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book book1;
        private void button2_Click(object sender, EventArgs e)
        {
            SealedClass sealedC = new SealedClass();
            sealedC.number1 = 10;
            sealedC.number2 = 25;
            int total= sealedC.number1+sealedC.number2;
            sealedC.resultText = "Result: " + total;

            MessageBox.Show(sealedC.resultText);
            MessageBox.Show("*/*/*/*/*/*/*/");
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            MessageBox.Show(book1.ISBNNo+"-"+book1.Author+" "+book1.Name+" "+book1.Genre);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book1.Author = "Paulo Choelho";
            book1.Genre = "Novel";
            book1.ISBNNo = "1236566983";
            book1.Name = "Brida";
            book1.Id = 125;
            // constructor olduğundan istersek ctor ile de direkt atama yapabiliriz
            Book book2=new Book(1,"İstanbul Hatırası","Novel","13264654","Ahmet Ümit");// ancak globalde tanımlamadığımız için buranın dışına çıkmaz!!!!!!!!!!
        }
    }
}
