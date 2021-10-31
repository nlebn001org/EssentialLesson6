using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson6Task3
{
    static class AscClass
    {

        public static int[] AscMethod(this int[] array)
        {
            Array.Sort(array);
            return array;
        }

    }
}
