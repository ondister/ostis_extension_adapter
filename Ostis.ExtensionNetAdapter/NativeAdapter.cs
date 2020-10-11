using System;
using System.IO;

namespace Ostis.ExtensionNetAdapter
{
    public static class NativeAdapter
    {
        [DllExport]
        public static int sc_module_initialize()
        {
            File.Create("1.txt");
            Console.WriteLine("!!!!! I did it!!!!");
            return 1;
        }

        [DllExport]
        public static int sc_module_shutdown()
        {
            File.Create("2.txt");
            return 1;
        }
    }
}
