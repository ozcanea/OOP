using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    abstract class Instrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract string Play();
        //abstract olduğundan gövdesiz

        public virtual string PlayIfYouWant()
        {
            return "This Text Belongs To PlayIfYouWant Method";
        }
        public string PlayWhateverYouWant()
        {
            return "Method Named You Can Play What You Want ";
        }
    }
}
