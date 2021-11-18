using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод градусов в радианы");
            GradToRadian grad = new GradToRadian();
            
            Console.WriteLine(grad.GradToRad()); 
            Console.ReadKey();
            
        }
    }
    class GradToRadian
    {
        double gr;
        double mi;
        double se;

        public double Gradus 
        {
            set
            {
                if (value >= 0)
                {
                    gr = value;
                }
                else
                {
                    Console.WriteLine("Число должно быть положительным");
                    System.Environment.Exit(0);
                }
            }
            get
            {
                return gr;
            }
        
        }
        public double Min
        {
            set
            {
                if (value >= 0)
                {
                    mi = value;
                    
                }
                else
                {
                    Console.WriteLine("Число должно быть положительным");
                    System.Environment.Exit(0);
                }
            }
            get
            {
              return mi;
            }
        }       
        public double Sec
        {
            set
            {
                if (value >= 0)
                {
                    se = value;

                }
                else
                {
                    Console.WriteLine("Число должно быть положительным");
                    System.Environment.Exit(0);
                }
            }
            get
            {
                return se;
            }
        }
        public GradToRadian()
        {
            try
            {
                Console.Write("Введите градусы:");
                Gradus = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Введите минуты:");
                Min = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Введите секунды:");
                Sec = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("{0} градусов {1} минут {2} секунд =", Gradus, Min, Sec);
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректно введены данные");
                System.Environment.Exit(0);
            }
            
        }

        public string GradToRad()
        {
            double decRad = Gradus + (Min + Sec / 60) / 60;
            double rad = decRad * Math.PI / 180;
            rad = Math.Round(rad,5);
            string stringRad = Convert.ToString(rad)+" радиан";
            return stringRad;
        }
    }
}
