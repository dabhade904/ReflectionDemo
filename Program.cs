using ReflectionDemo;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Type t = a.GetType();
            Console.WriteLine(t);
            Type type = typeof(System.String);
            Console.WriteLine(type);
            Console.WriteLine(type.Assembly);
            Console.WriteLine("-------------------------------");
            Type type1 = typeof(Add);
            ConstructorInfo[] p = type1.GetConstructors(
             BindingFlags.Public | BindingFlags.Static |
             BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (ConstructorInfo c in p)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("------------------------------");
            MethodInfo[] m = type1.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo m2 in m)
            {
                Console.WriteLine(m2);
            }
        }
    }
}