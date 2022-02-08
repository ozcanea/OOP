using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class SealedClassInherit:SealedClassInherited
    {
        // GetUser() sealed olduğu için miras alınması durumda gözükmüyor başka bir classın içinde override edemeyiz.!!!!!!!!!!!!

        protected override void GetUser2()
        {
            base.GetUser2();
        }
    }
}
