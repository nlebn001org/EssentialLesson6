using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson6Task2
{
    class Note
    {
        #region helpingmaterials
        //static int[] a = new int[] { 131, 262, 523, 1046 };
        //static int[] b = new int[] { 147, 294, 587, 1174 };
        //static int[] c = new int[] { 165, 330, 656, 1318 };
        //static int[] d = new int[] { 175, 349, 698, 1396 };
        //static int[] e = new int[] { 196, 392, 784, 1568 };
        //static int[] f = new int[] { 220, 440, 880, 1760 };
        //static int[] g = new int[] { 247, 494, 988, 1976 };
        #endregion


        int frequency;
        int duration;
       
        public int Frequency { get { return frequency; } }
        public int Duration { get { return duration; } }

        public Note(int frequency)
        {
            this.frequency = frequency;
            duration = 200;
        }
    }
}
