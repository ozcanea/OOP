using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction
{
    internal class Member
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private short _age;
        public short Age 
        {
            get { return _age; } 
            set 
            {
                if (value <= 90 && value >= 10)
                    _age = value;
                else
                    System.Windows.Forms.MessageBox.Show("Age Must Be Between 10 And 90");
            } 
        }
        private double _height;
        public double Height { get { return _height; } set { _height = value; } }
        private double _weight;
        public double Weight { get { return _weight; } set { _weight = value; } }
         

    }
}
