using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //cannot inherit from 'SealedClass'
    internal class SealedClassInherited:BaseClass//:SealedClass
    {
        protected sealed override void GetUSer()
        {
            System.Windows.Forms.MessageBox.Show("Searching for User.....");
        }
        protected override void GetUser2()
        {
            System.Windows.Forms.MessageBox.Show("Searching for User2......");
        }
    }
}
