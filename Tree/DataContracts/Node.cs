namespace DataContracts
{
    public class Node
    {
        public string Name;
        public int Depth;
        public int Id;

        public Node Parent;
        public List<Node> Children = new List<Node>();
    }
}