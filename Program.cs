namespace OOP_PEREGRUZKA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 2; int b = 4;
            // A ad = new A(3,2.0f);
            //Console.WriteLine(ad+2.4f);
            Point a = new Point();
            Point b = new Point();
            a.X = 10;
            a.Y = 10;
            b.X = 10;
            b.Y = 10;
            if (a && b)//по сути делим амперсанты на две части a& / &b
            {

            }
            Rectangle rectangle = new Rectangle(5, 10);
            Square square = new Square { Length = 7 };
            Rectangle rectSquare = square;
            Shop laptops = new Shop(3);
            laptops[0] = new Laptop
            {
                Vendor = "Sumsung",
                Price = 5200
            };
            laptops[2] = new Laptop
            {
                Vendor = "LG",
                Price = 7777
            };
            //  Console.WriteLine(laptops[2].ToString());
            Employee employee1 = new Employee("Иванов Иван Иванович\n", new DateTime(1990, 02, 18),"+7909023592", 
                "ivanov@gmail.com\n", "Программист\n", "Разработка ПО\n", 200000);
            Employee employee2 = new Employee("\nИванов БОРИС Иванович\n", new DateTime(1991, 03, 12), "+7909023592\n",
                "ivanov2@gmail.com\n", "Программист\n", "Разработка ПО\n", 200001);
            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());
            employee2.Salare = employee2 + 190000.0m;//явное преобразование типов
            Console.WriteLine(employee1.Equals(employee2));
        }
    }

    public class A
    {
        public int Abc { get; set; }
        public int Bbc { get; set; }
        public A(int a, float b)
        {
            this.Abc = Abc;
            this.Bbc = Bbc;
        }
        //Перегруженные операторы - static
        //примеры перегрузок операторов
        public static float operator +(A a, float b) { return a.Abc + b; } //перегружаем оператор сложения
        public static float operator +(A a, A b) { return a.Abc + b.Abc; }
        public static bool operator >(A a, A b)

        {
            if (a.Abc > b.Abc) return true;
            else return false;
        }
        public static bool operator <(A a, A b)
        {
            if (a.Abc < b.Abc) return true;
            else return false;
        }
        public static A operator ++(A a)
        {
            a.Abc++;
            return a;
        }
        public static A operator --(A a)
        {
            a.Abc--;
            return a;
        }
        public static A operator -(A a)
        {
            a.Abc = -a.Abc;
            return a;
        }
        //true, false - перегрузка
        public static bool operator true(A a) { return a.Abc > 0; }
        public static bool operator false(A a) { return a.Abc == 0; }

        //перегрузка логического и &
        public static A operator &(A a, A b) { return a; }
        //  public static implicit operator Point(A a) { } //неявное преобразование типов
        // public static explicit operator Point(A a) { } //явное преобразование типов
    }
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point() { } //конструктор должен быть пустым
        public static Point operator &(Point a, Point b)
        {
            if ((a.X != 0 && a.Y != 0) && (b.X != 0 && b.Y != 0)) return b;
            return new Point();
        }
        public static bool operator true(Point point)
        {
            return point.X != 0 || point.Y != 0 ? true : false;
        }
        public static bool operator false(Point point)
        {
            return point.X != 0 || point.Y != 0 ? true : false;
        }
    }

   
    class Rectangle
    {
        public int Wigth { get; set; }
        public int Height { get; set; }
        public Rectangle(int Wigth, int Height)
        {
            this.Wigth = Wigth;
            this.Height = Height;
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Length * 2, s.Length);
        }
    }
    class Square 
    { 
        public int Length { get; set; } 
        //тип_данных this[тип аргумента] {get; set;};
    }

    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor}{Price}";
        }
    }
   
    public class Shop
    {
        Laptop[] laptopsArr;
        public Shop(int size)
        {
            laptopsArr = new Laptop[size];
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopsArr.Length)
                
                    return laptopsArr[index];
                    throw new IndexOutOfRangeException();//индекс вышел за пределы массива
                
            }
            set
            {
                laptopsArr[index] = value;
            }
        }
    }
}
