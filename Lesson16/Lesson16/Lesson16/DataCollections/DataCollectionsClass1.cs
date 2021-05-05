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


            // SortedList<T>
            // LinkedList<T> - surišti objektai tarpusavyje (išmėtyti atmintyje)
            // Stack<T>
            // Quene<T>


            // HashSet
            // SortedSet
            // 


            // GetHaschCode - turi kiekvienas objektas, jis atmintyje nesikeičia (HaschTable - panaudojama Dictionary saugoti raktams ir value šalia)
        }

    }
}
