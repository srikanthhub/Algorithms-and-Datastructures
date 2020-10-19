using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Datastructures
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        /// <summary>
        /// Displays the elements in the linked list
        /// </summary>
        public void DisplayList()
        {
            Node p;

            //if list is empty return it
            if (start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            p = start;

            //loop till last node and print info in each node
            //assign the node with next link

            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Count the number of nodes present in a list
        /// </summary>
        public void CountNodes()
        {
            int n = 0;
            Node p = start;

            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("The number of Nodes in the List are: " + n);
        }

        /// <summary>
        /// Search an element in a list
        /// </summary>
        /// <param name="x">element to search</param>
        public bool Search(int x)
        {
            Node p = start;
            int position = 1;

            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }
                position++;
                p = p.link;
            }

            if (position == 0)
            {
                Console.WriteLine("The element " + x + "  doenot exist in the list");
                return false;
            }
            else
            {
                Console.WriteLine("The position of the element " + x + " is at : " + position);
                return true;
            }

        }

    }
}
