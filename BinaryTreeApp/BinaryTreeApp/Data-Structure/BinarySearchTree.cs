using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Tree implementations and order routes are based on http://csharpexamples.com/c-binary-search-tree-implementation/ source code.
/// Tree printing methods are based on https://www.baeldung.com/java-print-binary-tree-diagram source code but implemented for C#.
/// </summary>
namespace BinaryTreeApp.Data_Structure
{   /// <summary>
    /// Creates the Binary tree class with a root object
    /// </summary>
    class BinarySearchTree
    {
        public static Node Root { get; set; }
        /// <summary>
        /// Sets root to null so every change made just vanishes
        /// </summary>
        public static void Clear()
        {
            Root = null;
        }
        /// <summary>
        /// Adds a new node to the tree with the specified value
        /// </summary>
        /// <param name="value">Integer value to be set to a new node</param>
        /// <returns></returns>
        public static bool Add(int value)
        {
            Node before = null;
            Node after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) after = after.Left;
                else if (value > after.Data) after = after.Right;
                else return false;
            }

            Node newNode = new Node
            {
                Data = value
            };

            if (Root == null) Root = newNode;
            else
            {
                if (value < before.Data) before.Left = newNode;
                else before.Right = newNode;
            }

            return true;
        }
        /// <summary>
        /// Overloaded method for calling the pre-order traverse logical method with the root used at the moment
        /// </summary>
        /// <returns></returns>
        public static String TraversePreOrder()
        {

            return (TraversePreOrder(Root, "PRE-ORDER SEQUENCE: "));

        }
        /// <summary>
        /// Recursive method for traversing and printing the tree in pre-order
        /// </summary>
        /// <param name="parent">Is the node whose children are going to be traversed</param>
        /// <param name="result">String value for the result</param>
        /// <returns>Returns string value of the traverse </returns>
        private static String TraversePreOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result += parent.Data + " ⇒ ";
                result += TraversePreOrder(parent.Left, "");
                result += TraversePreOrder(parent.Right, "");
            }
            return result;
        }
        /// <summary>
        /// Overloaded method for calling the in-order traverse logical method with the root used at the moment
        /// </summary>
        /// <returns></returns>
        public static String TraverseInOrder()
        {

            return (TraverseInOrder(Root, "IN-ORDER SEQUENCE: "));

        }
        /// <summary>
        /// Recursive method for traversing and printing the tree in in-order
        /// </summary>
        /// <param name="parent">Is the node whose children are going to be traversed</param>
        /// <param name="result">String value for the result</param>
        /// <returns>Returns string value of the traverse </returns>
        private static String TraverseInOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result += TraverseInOrder(parent.Left, "");
                result += parent.Data + " ⇒ ";
                result += TraverseInOrder(parent.Right, "");
            }

            return result;
        }
        /// <summary>
        /// Overloaded method for calling the post-order traverse logical method with the root used at the moment
        /// </summary>
        /// <returns></returns>
        public static String TraversePostOrder()
        {

            return (TraversePostOrder(Root, "POST-ORDER SEQUENCE: "));

        }
        /// <summary>
        /// Recursive method for traversing and printing the tree in post-order
        /// </summary>
        /// <param name="parent">Is the node whose children are going to be traversed</param>
        /// <param name="result">String value for the result</param>
        /// <returns>Returns string value of the traverse </returns>
        private static String TraversePostOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result += TraversePostOrder(parent.Left, "");
                result += TraversePostOrder(parent.Right, "");
                result += parent.Data + " ⇒ ";
            }
            return result;
        }
        /// <summary>
        /// Overload method for calling toString(String a, Boolean b, String printedtree, Node d) method with the root value.
        /// </summary>
        /// <returns></returns>
        public static String toString()
        {
            return toString("", true, "", Root);
        }
        /// <summary>
        /// Method for printing the tree in a basic visual way
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="isTail">Boolean that indicates if the node is tail</param>
        /// <param name="result">This will be the tree, so start as a "".</param>
        /// <param name="head">This is the node that is being added at the moment</param>
        /// <returns></returns>
        public static String toString(String prefix, Boolean isTail, String result, Node head)
        {
            if (head.Right != null)
            {
                result += toString(prefix + (isTail ? "│   " : "    "), false, "", head.Right);
            }

            result += prefix + (isTail ? "|__" : "|‾‾") + "(" + head.Data + ")" + "\n";

            if (head.Left != null)
            {
                result += toString(prefix + (isTail ? "    " : "│   "), true, "", head.Left);
            }
            return result;
        }

    }

}
