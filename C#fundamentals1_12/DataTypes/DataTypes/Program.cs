using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string stringVar = "Hello";
            int intVar = 10;
            float floatVar = 10.2f;
            bool boolVar = true;
            char charVar = 'A';

            Console.WriteLine(stringVar);
            Console.WriteLine(intVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);

            //
            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 88755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;

            Console.WriteLine(ui);
            Console.WriteLine(fl);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(d);
            Console.WriteLine(mon);

            //
            int i = 100;
            uint u = (uint)i;
            Console.WriteLine(i);

            //Number-Byte
            byte b1 = 255;
            byte b2 = 0; 
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine(Byte.MaxValue);
            Console.WriteLine(Byte.MinValue);
            Console.WriteLine(SByte.MaxValue);
            Console.WriteLine(SByte.MinValue);

            //Number-Short
            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000; //compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //ushort us2 = -32000; // compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine(UInt16.MinValue);

            //Number-Int
            int m = -2147483648;
            int j = 2147483647;
            //int k = 4294967294; // compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            //uint ui2 = -1; // compile-time error
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt32.MinValue);


            //Number-Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(UInt64.MinValue);

            //Number-float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine(f1);
            Console.WriteLine(f2);

            //Number-Double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //Number-Decimal
            decimal de1 = 123456789123456789123456789.5m;
            decimal de2 = 1.1234567891345679123456789123m;

            Console.WriteLine(de1);
            Console.WriteLine(de2);

            //Number-Scientific Notation
            double dou = 0.12e2;
            Console.WriteLine(dou);

            float f = 123.45e-2f;
            Console.WriteLine(f);

            decimal dec = 1.2e6m;
            Console.WriteLine(dec);

            //String Type Variables
            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            Console.WriteLine(ch);
            Console.WriteLine(word);
            Console.WriteLine(text);

            //String and string
            string str1 = "Hello"; // uses string keyword
            String str2 = "Hello"; // uses System.String class

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //String as char Array
            char[] chars = { 'H', 'E', 'L', 'L', 'O' };

            string string1 = new string(chars);
            String string2 = new string(chars);

            foreach(char c in string1)
            {
                Console.WriteLine(c);
            }

            //Escape Sequence
            string str = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str);
            Console.WriteLine(path);
            Console.WriteLine(email);

            //Multi-line String
            string str3 = "this is a \n" +
            "multi line \n" +
            "string";

            Console.WriteLine(str3);

            string str4 = @"this is a 
					multi line 
					string";

            Console.WriteLine(str4);

            //String Concatenation
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";
            Console.WriteLine(name);
            Console.WriteLine(agent);
            Console.WriteLine(fullName);

            //
        }
    }
}
