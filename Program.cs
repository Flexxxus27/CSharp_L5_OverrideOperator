namespace CSharp_L5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Иванов Иван Иванович", new DateTime(1990, 5, 14), "+79342392", "Ivanov@ex.com", "Программист", "Разработка ПО", 50000);
            Employee employee2 = new Employee("Альбертов Генадий Сергеевич", new DateTime(1985, 2, 23), "+79678322", "Albertov@ex.com", "Дизайнер", "3D дизайн", 47000);

            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());
            employee2.Salary = employee2 + 3000;
            Console.WriteLine(employee1.Equals(employee2));
        }
    }
        public class A 
        {
            public int Abc { get; set; }
            public float Bbc { get; set; }
            public A(int Abc, float Bbc)
            {
                this.Abc = Abc;
                this.Bbc = Bbc;
            }

            public static float operator +(A a, float b) { return a.Abc + b; }
            public static int operator +(A a, A b) { return a.Abc + b.Abc; }
            public static bool operator >(A a, A b)
            {
                if (a.Abc > b.Abc) return false;
                else return true;
            }
            public static bool operator <(A a, A b)
            {
                if (a.Abc > b.Abc) return false;
                else return true;
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

            public static A operator -(A a) { a.Abc = -a.Abc; return a; }
            public static bool operator true(A a) {  return a.Abc > 0; }
            public static bool operator false(A a) { return a.Abc == 0; }
            public static A operator &(A a, A b) { return a; }
            //public static implicit operator Point (A a) { } //неявное
            //public static explicit operator Point(A a) { }  //явное
    }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point() { }
            public static Point operator &(Point a, Point b)
            {
                if((a.X != 0 && a.Y != 0) && (b.X != 0 && b.Y != 0))
                {
                    return b;
                }
                return new Point();
            }
            public static bool operator true(Point p)
            {
                return p.X != 0 && p.Y != 0 ? true : false;
            }
            public static bool operator false(Point p)
             {
                 return p.X == 0 && p.Y == 0 ? true : false;
             }

        }
    abstract class Figure
    {
        public abstract void Draw();
    }
    abstract class Quadrangle : Figure { }

    class Rectangle 
    { 
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int Width, int Height) 
        { 
            this.Width = Width;
            this.Height = Height;
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Length * 2, s.Length);
        }
    }
    class Square 
    {
        public int Length {  get; set; }
        
    }

    public class Laptop
    {
        public string Vendor {  get; set; }
        public double Price {  get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }
    public class Shop
    {
        Laptop[] laptopArr;
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length) { return laptopArr[index]; }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }
    }

}
