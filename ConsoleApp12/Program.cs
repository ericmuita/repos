using System;

namespace ConsoleApp12
{
    public class NullableTypesExample
    {
        static int? _testValue;
        public static void Main()
        {
            if (_testValue == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(_testValue.ToString());
        }
    }
}
