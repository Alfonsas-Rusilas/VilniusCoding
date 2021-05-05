using System;

namespace Lesson16
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testStr1 = "123456789";
            
            char test = testStr1[2];
            
            string test2 = testStr1.Substring(5, 10);

            int temp = 22;
            string test3 = String.Format("The temperature is {0}C.", temp);

            string test4 = test3.Remove(0, 1);

            test4 = test4.Replace("he", "The");

            test4 = test4.Insert(50, " DDDIDELIS");

            test4 = String.Concat("| ", test4, "   |");

            string[] test5 = test4.Split(" ");

            string test7 = String.Join(test4, test3, testStr1);

            int a = String.Compare(test4, test2);

            Console.WriteLine($"{String.IsNullOrEmpty(test7)}");
            Console.WriteLine($"{String.IsNullOrWhiteSpace(test7)}");

            //string str_clone = test4.Clone(); 

            char[] chars = test4.ToCharArray();

            int b = test4.IndexOf('g');

            b = test4.LastIndexOf('a');

            b = test4.IndexOfAny(chars);

            bool bulio = test4.StartsWith("Ana");

            // StringBuilder
            // Append(), AppendLine(), AppendFormat(), Insert()
            // Replace()
            // REmove(), Clear()
            // CopyTo()
            // ToString(), ToString(start, length)


        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

    }
}
