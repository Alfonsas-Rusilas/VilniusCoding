using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Lesson16.DataCollections4
{
    class DataCollectionsClass1
    {
        static void Main()
        {
            // List<T> - iš esmės lėtas, bet labai patogus

            // Dictionary<TKey, TValue> - labai greiti veiksmai, pav. Dictionary<int, string> d = new Dictionary<int, string>();
            //  {1, "vienas"},
            //  {2, "du"}
            // galima .Add(4,"zz");  // jei jau yra, gausim klaidą 
            // arba d[4] = "zz"  // daro owerwrite
            // string el = d[4]

            // SortedDictionary<TKey, TValue>
            // atmintyje jau neturi HashTable, saugo BinaryTree, t.y. gamina 'medį', ir gaunasi logaritminis greitis
            // foreach (KeyValuePAir<> kvp in manoZodynas) kvp.key arba kvp.Value 

            // LinkedList<T> - surišti objektai tarpusavyje (išmėtyti atmintyje)
            // Žinoma pradžią ir pabaigą (head ir pabaigą), vienas vidurinis narelis turi: data, previous, next

            // SortedList<T>

            // Quene<T>     // FIFO
            // padarytas masyvo pagrindu, formuojama eilė su vienodo tipo kantamuoju (padaryti masyvo pagrindu)
            // Count, Enquene(T) - prideda į galą, Dequene(T) - paima iš pradžio, Contains(), ToArray()

            // Stack<T>     // LIFO
            // eilė su funkcija: pirmas pridėtas į sąrašą bus apdorojamas paskutinis (padaryti masyvo pagrindu)
            // Push(), Pop(); Peek(), Contains(), Count, ToArray()

            // ArrayList - aukštesnio lygio nei Array, žemesnio nei List

            // HashSet - padaryti masyvo pagrindu, elementų krūva, visi unikalūs (binary Tree)
            // SortedSet - padaryti masyvo pagrindu, elementų krūva, visi unikalūs (binary Tree)

            // GetHaschCode - turi kiekvienas objektas, jis atmintyje nesikeičia (HaschTable - panaudojama Dictionary saugoti raktams ir value šalia)

            // --------------------
            // Tuple - tipizuotų duomenų krūva
            // Tuple author = new Tuple<string, string, int>("Jonas", "Jonaitis", 2003);


            Dictionary<string, int> manoZodynas0 = new Dictionary<string, int>();
            Dictionary<string, List<int>> manoZodynas1 = new Dictionary<string, List<int>>();

            for (int i = 0; i < 10; i++)
            {
                manoZodynas0.Add("Key" + i, i * 2);
            }

            List<int> intList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i * i);
            }

            for (int i = 0; i < 10; i++)
            {
                manoZodynas1.Add("List2_" + i, intList);
            }

            foreach (var Zod1 in manoZodynas0)
            {
                Console.WriteLine("Key: " + Zod1.Key + "  Value =" + Zod1.Value);
            }

            foreach (var Zod2 in manoZodynas1)
            {
                Console.WriteLine("Key: " + Zod2.Key + "  Value =" + String.Join(' ', Zod2.Value));
            }

            int X = 0;
            manoZodynas0.TryGetValue("Some", out X);
            Console.WriteLine("Some=" + X);
            manoZodynas0.TryGetValue("Key8", out X);
            Console.WriteLine("Key8=" + X);
            Console.WriteLine("-----------------------------------------------");


            Stack<string> kruva = new Stack<string>();
            kruva.Push("Pirmas elementas");
            kruva.Push("Antras elementas");
            kruva.Push("Trečias elementas");
            kruva.Push("Ketvirtas elementas");
            string someStack = kruva.Pop();
            Console.WriteLine("Stako value:" + someStack);
            do
            {
                someStack = kruva.Pop();
                Console.WriteLine("Stako value:" + someStack);
            } while (kruva.Count > 0);

            Console.WriteLine("-----------------------------------------------");
            Queue<string> eile = new Queue<string>();
            eile.Enqueue("Eilė-" + "Pirmas");
            eile.Enqueue("Eilė-" + "Antras");
            eile.Enqueue("Eilė-" + "Trečias");
            eile.Enqueue("Eilė-" + "Ketvirtas");
            eile.Enqueue("Eilė-" + "Penktas");
            string someQuene = eile.Dequeue();
            Console.WriteLine("Quene value:" + someQuene);
            do
            {
                someQuene = eile.Dequeue();
                Console.WriteLine("Quene value:" + someQuene);
            } while (eile.Count > 0);

            


        }

    }
}
