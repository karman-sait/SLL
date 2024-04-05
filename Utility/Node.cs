// Name: Kiru and Karman, Date: 4/4/23, Program Description: Implementation of a linked list ADT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{

    // Represents a node in a linked list

    public class Node
    {
        public User Value { get; set; } // Data in the node
        public Node Next { get; set; }  // Reference to the next node

        public Node(User value)
        {
            Value = value;
            Next = null;
        }
    }
}
