using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EssentialLesson6Task2
{
    static class Player
    {

        static public void Play(List<Note> notes)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Frequency==0)
                {
                    Thread.Sleep(500);
                }
                else 
                {
                    Console.Beep(notes[i].Frequency, notes[i].Duration);
                }
            }

        }

    }
}
