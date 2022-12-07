// See https://aka.ms/new-console-template for more information
using DataContracts;
using System.Xml.Linq;
using Services;

var nodeService = new Services.NodeService();

List<Node> tree = nodeService.getTree();
Node node = tree.First();
//List<Node> nodes = nodeService.getThree();

//Ancienne version
//foreach (Node node in nodes)
//{
//PrintTree(node);
//}

//void PrintTree(Node node, int depth = 0)
//{
//    for (int i = 0; i < depth; i++)
//    {
//        Console.Write("  ");
//    }

//    Console.WriteLine(node.Name);

//    foreach (Node child in node.Children)
//    {
//        PrintTree(child, depth + 1);
//    }
//}

//void print(List<Node> root, String prefix)
//{
//    foreach(Node node in root)
//    {

//        if (node == null)
//        {
//            Console.WriteLine(prefix + "+- <null>");
//            return;
//        }

//        Console.WriteLine(prefix + "+- " + node.Name);
//        print(node.Children, prefix + "|  ");
//    }
//}

ExtentionMethode.print(tree, "");