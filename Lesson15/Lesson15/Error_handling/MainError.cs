using Lesson15.Error_handling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Error_handling
{
    class MainError
    {
        public static void Main()
        {
            ErrorTest errorTest = new ErrorTest();

            try
            {
                errorTest.DoSomeThingBad();
            } catch (MySuperExceptions e)
            {
                Console.WriteLine(e.Message);
            }


            Console.Write("Įveskite skaičių: ");
            int[] masyvas = new int[3];
            try
            {
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            } catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            } catch (IndexOutOfRangeException except3)
            {
                Console.WriteLine("Blogai naudojamas masyvas: " + except3.Message);
            }
            catch (Exception exeption2)
            {
                Console.WriteLine("Last error: " + exeption2.Message);
            }
            finally // šis blokas įvykdomas visada 
            {
                Console.WriteLine("Always do it!");
            }


            



        }
    }
}
