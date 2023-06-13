using System;

namespace oop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.menu();
        }
    }

    class TCircle {

        protected int rad;
        protected int x;
        protected int y;
        private double sq;
       
        public TCircle() {
            
        }
        public TCircle(int rad, int x, int y) {
            this.rad = rad;
            this.x = x;
            this.y = y;
            }
        public TCircle(TCircle anotherCircle) {

            this.rad = anotherCircle.rad;
            this.x = anotherCircle.x;
            this.y = anotherCircle.y;

        }

        public virtual void filldata()
        {
            Console.WriteLine("введiть координати центра кола:");
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("введiть радiус кола: ");
            rad = Convert.ToInt32(Console.ReadLine());

            if (rad <= 0)
            {
                Console.WriteLine("!введiть невiд'ємне значення радiуса!");
                filldata();

            }
        }

        public virtual void outdata()
        {
            Console.WriteLine("Pадiус: "+rad);
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }

        public void square()
        {
            sq = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("Площа  кола: " + sq);
        }

        public virtual void point()
        {
              int x1;
              int y1;
             Console.WriteLine("введiть координати точки:");
            Console.Write("x=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y1 = Convert.ToInt32(Console.ReadLine());
            if(Math.Pow((x1-x),2)+ Math.Pow((y1 - y), 2) < Math.Pow(rad, 2)){

                Console.WriteLine("Точка входить в круг");
              
            }
            if (Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) == Math.Pow(rad, 2))
            {
                Console.WriteLine("Точка входить в коло круга");
            }
            else { Console.WriteLine("Точка не входить в круг"); }
        }
        public static TCircle operator +(TCircle circle1, int rad) => new TCircle(circle1.rad + rad, circle1.x, circle1.y);
        public static TCircle operator -(TCircle circle1, int rad) => new TCircle(circle1.rad - rad, circle1.x, circle1.y);
        public static TCircle operator *(TCircle circle1, int  num) => new TCircle(circle1.rad * num, circle1.x, circle1.y);
    }

    class TBall : TCircle
    {
        private double v;
        private int z;
        

        public TBall() { }
        public TBall(int rad, int x, int y)
        {
            this.rad = rad;
            this.x = x;
            this.y = y;
        }
        public TBall(TBall anotherBall)
        {
            this.rad = anotherBall.rad;
            this.x = anotherBall.x;
            this.y = anotherBall.y;

        }
       
        public override void filldata()
        {
            base.filldata();
            Console.Write("z=");
            z = Convert.ToInt32(Console.ReadLine());
        }

        public override void outdata()
        {
            base.outdata();
            Console.WriteLine("z: " + z);
        }
        public override void point()
        {
            int x1;
            int y1;
            int z1;
            Console.WriteLine("введiть координати точки:");
            Console.Write("x=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z=");
            z1 = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2)+Math.Pow((z1 - z), 2) <= Math.Pow(rad, 2))
            {
                Console.WriteLine("Точка входить в шар");
            }
            
            else { Console.WriteLine("Точка не входить в шар"); }
        }

        public void volume()
        {
            v = (4 * Math.PI * Math.Pow(rad, 3)) / 3;
            Console.WriteLine("Об'єм шара: " + v);
        }
        
    }
    static class Menu
    {
        public static void menu()
        {
            Console.WriteLine("1.Звичайний конструктор");
            Console.WriteLine("2.Конструктор  з параметрами");
            Console.WriteLine("3.Конструктор копiювання");
            Console.WriteLine("4.Перевантаження оператiв");
            Console.WriteLine("5.Hаслiдування");
            Console.Write("\nОберiть операцiю:");
            int ch = Convert.ToInt32(Console.ReadLine());

            TCircle circle = new TCircle();
            TCircle circle2 = new TCircle(20, 20, 30);
            switch (ch)
            {
                case 1:
                    Console.WriteLine("\nЗвичайний конструктор:");
                    circle.filldata();
                    circle.outdata();
                    circle.square();
                    circle.point();
                    choise();
                    break;
                case 2:
                    Console.WriteLine("\nКонструктор  з параметрами:");
                    circle2.outdata();
                    circle2.square();
                    circle2.point();
                    choise();
                    break;
                case 3:
                    Console.WriteLine("\nКонструктор копiювання:");
                    TCircle circle3 = new TCircle(circle2);
                    circle3.outdata();
                    circle3.square();
                    circle3.point();
                    choise();
                    break;

                case 4:
                    Console.WriteLine("\nПеревантаження оператiв:");
                    TCircle circle4 = circle2 + 5;
                    circle4.outdata();
                    TCircle circle5 = circle2 - 5;
                    circle5.outdata();
                    TCircle circle6 = circle2 * 5;
                    circle6.outdata();
                    choise();
                    break;
                case 5:
                    Console.WriteLine("\nHаслiдування:");
                    TBall ball = new TBall();
                    ball.filldata();
                    ball.outdata();
                    ball.point();
                    choise();
                    break;
                default:
                    Console.WriteLine("\n!Введiть коректне значення!");
                    menu();
                    break;
            }
        }

        public static void choise()
        {
            Console.Write("\nПродовжуємо? Введiть \"так\" або \"нi\":\n");
            string chh = Console.ReadLine();
            switch (chh)
            {
                case "так":
                    menu();
                    break;
                case "ні":
                     break;
                default:
                    Console.WriteLine("!Введiть коректну вiдповiдь!");
                    choise();
                    break;
            }
        }
    }
}

