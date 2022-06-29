using System;

namespace Завдання1
{
    class House
    {
        public List<Door> Doors { get; }
        public List<Window> Windows { get; }

        public House(List<Window> window, List<Door> door)
        {
            Windows = window;
            Doors = door;
        }

        public void AddWindows(Window windows)
        {
            Windows.Add(windows);
        }
        public void AddDoors(Door doors)
        {
            Doors.Add(doors);
        }
        
        public void Keys(Door door)
        {
            door.Locker();
        }

        public void Print()
        {
            Console.WriteLine("У наявності нашої компанії будинок у скандинавському стилі.");
            Console.WriteLine("Дім на продаж. Базова інформація:");
            Console.WriteLine($"Кількість вікон у ньому: {Windows}");
            Console.WriteLine($"Kількість дверей: {Doors}");
        }

        /* public override string ToString()
         {
             Console.WriteLine("Застосовано метод ToString");
 
             return $"{w}:{d}";
         }
 */
        public override int GetHashCode()
        {
            int hashcode = Windows.GetHashCode();
            hashcode += Doors.GetHashCode();
            Console.WriteLine($"HashCode = {hashcode}");
            return hashcode;
        }

        /*public override bool Equals(object obj)
        {
            if (obj == null) return false;
            House h = obj as House;
            if (h == null) return false;

            if (h.d == d && h.w == w)
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
*/
        public class Window
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

        public class Door
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

                
                

                //u.GetHashCode();
                //Console.WriteLine(w.ToString());
                //Console.WriteLine(u.Equals(u));// true 
                Console.ReadLine();
            }
        }
    }
}