using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ExtentionMethode
    {
        public static void print(List<Node> root, String prefix)
        {
            foreach (Node node in root)
            {

                if (node == null)
                {
                    Console.WriteLine(prefix + "+- <null>");
                    return;
                }

                Console.WriteLine(prefix + "+- " + node.Name);
                print(node.Children, prefix + "|  ");
            }
        }

    }
}
