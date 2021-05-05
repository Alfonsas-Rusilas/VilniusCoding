using BigHomeWork3.Lesson13.StaticUzduotys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson13
{
    class MainClass13
    {
        static void Main()
        {
            // static - skirtas unikaliems vienetiniams dalykams padaryti
            // static - gali būti bet koks klasės narys, ir jis bus VIENINTELIS mūsų atmintyje. Ir globalus, pasiekiamas viešai;
            // static - jis nepatenka į tos klasės objektus, jis turi savo vietą (specialiame objekte - Class Object).
            // Jei visa klasė pažymėta static - ji negalės turėti objektų (naudosime jos globalias funkcijas, pav. Pi, konvertavimai ir kt.)
            // readonly - kintamieji patampa tik skaitomi (pirma reikšmė priskiriama konstruktoriuje)
            // const = static readonly elementas. Panašiai kaip static, bet tik skaitymui, o reikšmę įgauna kompiliuojant.
            //
            // overloading - iššaukiam tą pačią funkciją su tuo pačiu pavadinimu, bet su skirtingais parametrais 
            // overloading - galima ir vienanariais, galima su dvinariais operatoriais
            //
            // 



            StaticClass1 sc1 = new StaticClass1();
            StaticClass2 sc2 = new StaticClass2();
            StaticClass3 sc3 = new StaticClass3();

            sc1.CallMembers_StaticClass1();
            sc2.CallMembers_StaticClass2();
            sc3.CallMembers_StaticClass3();

   
            /*                      pasiekiami tiesiogiai static nariai:
            StaticClass1.Pi;
            StaticClass2..
            StaticClass3.MoonCount
            StaticClass3.ShowMoonCount
            */

            Console.ReadLine();

        }
    }
}
