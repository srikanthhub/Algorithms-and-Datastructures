namespace Algorithms_and_Datastructures
{
    public class Node
    {
        public int info;
        public Node link;

        public Node(Node i)
        {
            info = i.info;
            link = i.link;
        }
    }
}