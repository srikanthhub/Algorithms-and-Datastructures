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

        /// <summary>
        /// This method inserts the new node after given element
        /// </summary>
        /// <param name="data">The node to insert</param>
        /// <param name="element">insert after element </param>
        public void InsertAfter(Node data, int element)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == element)
                    break;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(element + " Not present in the list");
            }
            else
            {
                Node newNode = new Node(data);
                newNode.link = p.link;
                p.link = newNode;
            }
        }

        /// <summary>
        /// This method inserts the new node before given element
        /// </summary>
        /// <param name="data">New node to insert</param>
        /// <param name="element">insert before the element</param>
        public void InsertBefore(Node data, int element)
        {
            Node p = start;
            Node newNode;

            if (start == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            // if the element is at first node then we need to insert the new node bofere the first node

            if (element == start.info)
            {
                newNode = new Node(data);
                newNode.link = start;
                start = newNode;
                return;
            }
            while (p.link != null)
            {
                if (p.link.info == element)
                    break;
                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(element + " Not present in the list");
            }
            else
            {
                newNode = new Node(data);
                newNode.link = p.link;
                p.link = newNode;
            }
        }

        /// <summary>
        /// Insert a node at given position
        /// </summary>
        /// <param name="data">Node to insert</param>
        /// <param name="position">position to insert</param>
        public void InsertAtPosition(Node data, int position)
        {
            Node newNode;
            int i;

            if (position == 1)
            {
                newNode = new Node(data);
                newNode.link = start;
                start = newNode;
                return;
            }

            Node p = start;

            for (i = 1; i < position - 1 && p != null; i++ )
            {
                p = p.link;
            }


            if (p == null)
            {
                Console.WriteLine("You can only insert at posiytion " + i);
                return;
            }
            else
            {
                newNode = new Node(data);
                newNode.link = p.link;
                p.link = newNode;
            }
        }

        /// <summary>
        /// Deletes the first node
        /// </summary>
        public void DeleteFirstNode()
        {
            if (start == null)
            {
                return;
            }

            start = start.link;
        }

        /// <summary>
        /// Deletes the Last Node
        /// </summary>
        public void DeleteLastNode()
        {
            if (start == null)
            {
                return;
            }

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node tempNode = start;
            while (tempNode.link.link != null)
            {
                tempNode = tempNode.link;
                tempNode.link = null;
            }
        }

        /// <summary>
        /// Delete a Node at given position
        /// </summary>
        /// <param name="x"></param>
        public void DeleteNode(int x)
        {
            if (start == null)
            {
                return;
            }

            //Delete first node

            if(start.info==x)
            {
                start = start.link;
                return;
            }

            //Deletion in between or at the end

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                {
                    break;
                }

                p = p.link;
            }


            if (p.link == null)
            {
                Console.WriteLine("Element not in the list);
            }
            else
            {
                p.link = p.link.link;
            }

        }
    }
}
