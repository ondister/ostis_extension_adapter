using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ostis.ExtensionNetAdapter
{
    public static class NativeAdapter
    {
        [UnmanagedCallersOnlyAttribute(EntryPoint = "sc_module_initialize")]
        public static int sc_module_initialize()
        {
           
            Console.WriteLine("!!!!! I did it!!!!");
            return 1;
        }

        [UnmanagedCallersOnlyAttribute(EntryPoint = "sc_module_shutdown")]
        public static int sc_module_shutdown()
        {
            Console.WriteLine("!!!!!Module done!!!!");
            return 1;
        }
    }
}
