using System;

namespace HashTables
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTables");
            MyMapNode<string, string> mapNode = new MyMapNode<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            mapNode.Add("0", "to");
            mapNode.Add("1", "be");
            mapNode.Add("2", "or");
            mapNode.Add("3", "to");
            mapNode.Add("4", "be");
            mapNode.Add("5", "not");
            mapNode.GetFreq("to");


        }
    }
}
