using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal sealed class Singleton
    {
        private static Singleton Instance = null;
        private static int Count = 0;
        private static readonly object obj = new object();

        public static Singleton GetSingleton
        {
            get
            {
                lock (obj)
                {
                    if (Instance == null)
                    {

                        Instance = new Singleton();
                        return Instance;


                    }
                    else
                        return Instance;
                }
                
            }
        }
        private Singleton()
        {
            Count++;
            Console.WriteLine("No of instances {0}", Count);
        }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
