using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Hand
{
    public class Arm
    {
        private Finger finger;
        public string ConnectionString { get; set; }

        public Arm()
        {

        }

        public void Connect(Finger finger)
        {
            this.finger = finger;
        }
    }
}
