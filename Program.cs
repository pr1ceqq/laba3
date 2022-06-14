using System;
using System.Collections.Generic;

namespace Завдання1
{
    class House
    {
        public int d { get; }
        public int w { get; }
        public string h { get; }

        public House(Window window, Door door, string h)
        {
            d = door.d;
            w = window.w;
            this.h = h;
        }

        public void Keys(Door door)
        {
            door.Locker();
        }

        public void Print()
        {
            Console.WriteLine("У наявності нашої компанії будинок у скандинавському стилі.");
            Console.WriteLine("Дім на продаж. Базова інформація:");
            Console.WriteLine($"Кількість вікон у ньому: {w}");
            Console.WriteLine($"Kількість дверей: {d}");
        }

        public override string ToString()
        {
            Console.WriteLine("Застосовано метод ToString");

            return $"{h}:{w}:{d}";
        }

        public override int GetHashCode()
        {
            int hashcode = h.GetHashCode();
            hashcode += d.GetHashCode();
            hashcode += w.GetHashCode();
            Console.WriteLine($"HashCode = {hashcode}");
            return hashcode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            House h = obj as House;
            if (h == null) return false;

            if (h.h == this.h && h.d == d && h.w == w)
            {
                Console.WriteLine("Об'єкти рівні між собою");
                return true;
            }
            else
            {
                Console.WriteLine("Об'єкти не є рівними між собою");
                return false;
            }
        }
    }

    class Window
    {
        public int w { get; set; }

        public Window(int w)
        {
            this.w = w;
        }

        public void Locker()
        {
            Console.WriteLine("Вікно зачинено");
        }

    }

    class Door
    {
        public int d { get; }

        //за допомогою base звертаємося до конструктора базового класу House

        public Door(int d)
        {
            this.d = d;
        }

        public void Locker()
        {
            Console.WriteLine("Двері зачинено на ключ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Door d = new Door(6);

            Window w = new Window(9);

            House u = new House(w, d, "");
            u.Keys(d);
            u.Print();

            //u.GetHashCode();
            //Console.WriteLine(w.ToString());
            //Console.WriteLine(u.Equals(u));// true 
            Console.ReadLine();
        }
    }
}

