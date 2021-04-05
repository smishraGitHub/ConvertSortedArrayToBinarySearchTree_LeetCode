using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSortedArrayToBinarySearchTree_LeetCode
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;

        }
    }
    public class BinaryTree
    {
        Node root;

        public Node ConvertToBST(int[] arr,int start,int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);

            node.left = ConvertToBST(arr, start, mid - 1);
            node.right = ConvertToBST(arr, mid + 1, end);


            return node;
        }

        public void preOrder(Node node)
        {
            if (node == null)
                return;
            Console.Write(node.data + " ");
            preOrder(node.left);
            preOrder(node.right);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            
            Node resultRoot=bt.ConvertToBST(arr, 0, n - 1);
            bt.preOrder(resultRoot);

            Console.ReadLine();

        }
    }
}
