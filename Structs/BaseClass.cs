using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class BaseClass
    {
        protected virtual void GetUSer()
        {
            System.Windows.Forms.MessageBox.Show("Get User Method1......");
        }
        protected virtual void GetUser2()
        {
            System.Windows.Forms.MessageBox.Show("Get User Method2......");
        }
    }
}
