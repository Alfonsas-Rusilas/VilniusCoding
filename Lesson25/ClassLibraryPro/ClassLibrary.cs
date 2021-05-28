using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPro
{
    internal class ClassMain
    {

        static void Main()
        {
            ClassLibrary parent = new ClassLibrary();

            ClassLibraryExtendet child = new ClassLibraryExtendet();

            Console.WriteLine($"parent: {parent.StrInternal}");
            Console.WriteLine($"parent: {parent.StrInternalProtected}");
            //Console.WriteLine($"parent: {parent.StrPrivateProtected}");
            //Console.WriteLine($"parent: {parent.StrProtected}");
            Console.WriteLine($"parent: {parent.StrPublic}");

            Console.WriteLine($"child.parent: {child.StrInternal}");
            Console.WriteLine($"child.parent: {child.StrInternalProtected}");
            //Console.WriteLine($"child.parent: {child.StrPrivateProtected}");
            //Console.WriteLine($"child.parent: {child.StrProtected}");
            Console.WriteLine($"child.parent: {child.StrPublic}");

            Console.WriteLine($"child: {child.StrInternalEx}");
            Console.WriteLine($"child: {child.StrInternalProtectedEx}");
            //Console.WriteLine($"child: {child.StrPrivateProtectedEx}");
            //Console.WriteLine($"child: {child.StrProtectedEx}");
            Console.WriteLine($"child: {child.StrPublicEx}");

        }
    }

    internal class ClassLibrary
    {
        public string StrPublic { set; get; } = "StrPublic";
        internal string StrInternal { set; get; } = "StrInternal";
        protected string StrProtected { set; get; } = "StrProtected";
        internal protected string StrInternalProtected { set; get; } = "StrInternalProtected";
        private protected string StrPrivateProtected { set; get; } = "StrPrivateProtected";
    }


        internal class ClassLibraryExtendet: ClassLibrary
    {
        public string StrPublicEx { set; get; } = "StrPublic";
        internal string StrInternalEx { set; get; } = "StrInternal";
        protected string StrProtectedEx { set; get; } = "StrProtected";
        internal protected string StrInternalProtectedEx { set; get; } = "StrInternalProtected";
        private protected string StrPrivateProtectedEx { set; get; } = "StrPrivateProtected";
    }


}
