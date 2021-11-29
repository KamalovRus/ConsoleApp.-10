using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle1 = new Angle(360, 300, 400);
            Console.WriteLine(Angle.ToRadians(new Angle(100, 8060, 60)));
            Console.WriteLine(Angle.ToRadians(angle1));
            Console.ReadKey();
        }
    }
    public class Angle
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine($"Угловые минуты это 1/60 градуса, добавляем {value / 60} к Gradus");
                    gradus += value / 60;
                    min = value % 60;
                }

            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine($"Угловые секунды это 1/60 угловой минуты, добавляем {value / 60} к Min");
                    min += value / 60;
                    sec = value % 60;
                }

            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public static double ToRadians(Angle angle)
        {
            Console.WriteLine("Радиан в данном угле: ");
            return (angle.Gradus / (180 / Math.PI)) + ((angle.Min * Math.PI) / (60 * 180)) + ((angle.Sec * Math.PI) / (180 * 3600));  
        }

       
    }
}
        
    

