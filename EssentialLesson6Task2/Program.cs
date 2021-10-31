using System;
using System.Collections.Generic;

namespace EssentialLesson6Task2
{


    //        Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: Создать класс Note, представляющий музыкальную ноту.Класс Note должен содержать следующие данные: частота, продолжительность в миллисекундах и значение типа bool, указывающее, является ли нота паузой. Создать 7 фабричных методов для создания нот (до, ре, ми, фа, соль, ля, си), фабричные методы в качестве параметров должны принимать номер октавы для соответствующей ноты и значение продолжительности в миллисекундах.Создать статический класс MelodyParser с методом для преобразовния строки из цифр и пробелов в массив нот: Note[] ParseMelody(string melody). Цифры от 0 до 9 соответствуют 10 последовательным нотам на Ваше усмотрение, пробел – паузе.Продолжительность звучания нот одинаковая и устанавливается на Ваше усмотрение.
    //Создать статический класс Player с методом для последовательного воспроизведения массива нот с помощью метода Console.Beep:
    //void Play(Note[] notes).
    //Пример использования описанных классов:
    //string melody = "987 876 765 654 543 432 111 8";
    //        Note[] notes = MelodyParser.ParseMelody(melody);
    //        Player.Play(notes);


    class Program
    {
        static int[] aa = new int[] { 131, 262, 523, 1046 };
        static int[] bb = new int[] { 147, 294, 587, 1174 };
        static int[] cc = new int[] { 165, 330, 656, 1318 };
        static int[] dd = new int[] { 175, 349, 698, 1396 };
        static int[] ee = new int[] { 196, 392, 784, 1568 };
        static int[] ff = new int[] { 220, 440, 880, 1760 };
        static int[] gg = new int[] { 247, 494, 988, 1976 };

        static string a = "1046 ";
        static string b = "1174 ";
        static string c = "1318 ";
        static string d = "1396 ";
        static string e = "1568 ";
        static string f = "1760 ";
        static string g = "1976 ";
        static string _ = " ";

        static void Main(string[] args)
        {
            string test = "523 587 656 698 784 880 988 1046";
            string test1 = _+_+e+a+c+b+a+e+d+b+a+c+b+g+b+e ;
            Console.WriteLine(test1);

            List<Note> notes = MelodyParser.ParseMelody(test1);

            Player.Play(notes);
        }
    }
}
