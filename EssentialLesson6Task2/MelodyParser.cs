using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson6Task2
{
    static class MelodyParser
    {
        static public List<Note> ParseMelody(string melody)
        {
            List<Note> notes = new List<Note>();
            List<char> c = new List<char>();

            for (int i = 0; i < melody.Length; i++)
            {
                if (melody[i] != ' ')
                {
                    c.Add(melody[i]);
                }
                else
                {
                    if (!c.Any())
                    {
                        notes.Add(new Note(0));
                    }
                    else
                    {
                        notes.Add(new Note(int.Parse(new string(c.ToArray()))));
                    }
                    c.Clear();
                }
            }
            return notes;
        }
    }
}
