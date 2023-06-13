using System;

namespace _2sem_7laba
{
    class Program
    {
        static void Main(string[] args)
        {  
            menu();

            void menu() {
                Methods methods = new Methods();
                Console.WriteLine("Оберіть завдання: ");
                Console.WriteLine("1. знаходження суми елементів статичного масиву ");
                Console.WriteLine("2. знаходження добутку елементів статичного масиву ");
                Console.WriteLine("3. знаходження середнього арифметичого елементів статичного масиву ");
                Console.WriteLine("4. знаходження суми елементів динамічного масиву ");
                Console.WriteLine("5. знаходження добутку елементів динамічного масиву ");
                Console.WriteLine("6. знаходження середнього арифметичого елементів динамічного масиву ");
                int choise = Convert.ToInt32(Console.ReadLine());
               
                switch (choise)
                {
                    case 1:
                        methods.StSuma();
                        menu2();
                        break;
                    case 2:
                        methods.StDob();
                        menu2();
                        break;
                    case 3:
                        methods.StSerAr();
                        menu2();
                        break;
                    case 4:
                        methods.DSuma();
                        menu2();
                        break;
                    case 5:
                        methods.DDob();
                        menu2();
                        break;
                    case 6:
                        methods.DSerAr();
                        menu2();
                        break;
                    default:
                        Console.WriteLine("Введіть коректне значення");
                        menu();
                        break;
                }
            }

            void menu2()
            {
                Console.WriteLine("Бажаєте продовжити? ");
                Console.WriteLine("1. так ");
                Console.WriteLine("2. ні");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        menu();
                        break;
                    case 2:
                        Console.WriteLine("Кінець програми :) ");
                        break;
                }
            }
        }
    }

    class Methods: IStatic, IDynamic
    {
        double[] staticarray = new double[] { 3, 4, 5, 7, 2, 13, 6, 9, 10 };
        int n;
        double[] dynamicarray;
        double suma = 0;
        double dob = 1;
        double sa;

        public void StSuma()
        {
            for (int i = 0; i < staticarray.Length; i++)
            {
                suma = suma + staticarray[i];
            }
            Console.WriteLine("Сума: " + suma);
        }
        public void StDob()
        {
            
            for (int i = 0; i < staticarray.Length; i++)
            {
                dob = dob * staticarray[i];
            }
            Console.WriteLine("Добуток: " + dob);
        }
        public void StSerAr()
        {
            
            for (int i = 0; i < staticarray.Length; i++)
            {
                suma = suma + staticarray[i];
            }
            sa = suma/ staticarray.Length;
            Console.WriteLine("Середнє арифметичне: " + sa);
        }
        public void DSuma()
        {
            Console.WriteLine("Введiть розмiрнiсть масиву");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            dynamicarray = new double[n];
            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " : ");
                dynamicarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < dynamicarray.Length; i++)
            {
                suma = suma + dynamicarray[i];
            }
            Console.WriteLine("Сума: " + suma);
        }

        public void DDob()
        {
            Console.WriteLine("Введiть розмiрнiсть масиву");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            dynamicarray = new double[n];
            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " : ");
                dynamicarray[i] = Convert.ToInt32(Console.ReadLine());
            } 

            for (int i = 0; i < dynamicarray.Length; i++)
            {
                dob = dob * dynamicarray[i];
            }
            Console.WriteLine("Добуток: " + dob);
        }

        public void DSerAr()
        {
            Console.WriteLine("Введiть розмiрнiсть масиву");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            dynamicarray = new double[n];
            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " : ");
                dynamicarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < dynamicarray.Length; i++)
            {
                suma = suma + dynamicarray[i];
            }

            sa = suma / dynamicarray.Length;
            Console.WriteLine("Середнє арифметичне: " + sa);
        }
    }
    interface IStatic
    {
        public void StSuma();
        public void StDob();
        public void StSerAr();
    }
    interface IDynamic
    {
        public void DSuma();
        public void DDob();
        public void DSerAr();
    }
}
