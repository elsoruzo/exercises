using System;

namespace ststic_field_orderOf_initializing
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Foo.Instance);
            Console.WriteLine(Foo.X);
        }   // 3 }

        class Foo
        {


            public static Foo Instance = new Foo();

            public static int X = 3;

            Foo()
            {
                Console.WriteLine(X);
            }   // 0 
        }
    }
}

//using System;
//using System.Linq;                


//public class Program
//{
//    class Cat  {
//        public int num;
//    }

//    public static void Main()
//    {
//        var i = new int[] {1,2,3}.Select(o => 
//		{
//			var cat = new Cat {num = o};
//			return cat;
//		});

//        foreach (var o in i)
//            o.num = 5;

//        foreach (var o in i)
//            Console.WriteLine(o.num);

//		foreach (var o in i)
//		{
//		           o.num = 5;
//            Console.WriteLine(o.num);
//		}
//    }
//}