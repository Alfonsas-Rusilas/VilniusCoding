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

            // SortedList<T>
            // LinkedList<T> - surišti objektai tarpusavyje (išmėtyti atmintyje)
            // Stack<T>
            // Quene<T>


            // HashSet
            // SortedSet
            // 

            // GetHaschCode - turi kiekvienas objektas, jis atmintyje nesikeičia (HaschTable - panaudojama Dictionary saugoti raktams ir value šalia)

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



        }

    }
}
