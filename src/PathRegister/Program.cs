using System;
using System.IO;
using System.Linq;

using libymtr.Windows;
using Registry = libymtr.Windows.Registry;

namespace PathRegister {
    internal class Program {
        private const string OPT_DELETE = "--delete";

        static void Main(string[] args) {
            string path = System.Environment.CurrentDirectory;

            if (args.Contains(OPT_DELETE)) {
                DeregisterPath(path);   //  delete
                return;
            }
            RegisterPath(path);     //  add
        }

        private static void RegisterPath(string path) {
            Registry.Environment.AddPath(path);
        }
        private static void DeregisterPath(string path) {
            Registry.Environment.RemovePath(path);
        }
    }
}
