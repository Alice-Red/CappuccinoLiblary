using System;
using System.Collections.Generic;
using System.Text;

namespace Cappuccino.Windows.Sounds
{
    public class Sound
    {


        public string Name;
        //public int Id;
        protected IntPtr offset;
        protected byte[] stream;

        public Sound(string name) {

        }

        public void PreLoad() {

        }

    }
}
