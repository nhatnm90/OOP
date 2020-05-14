using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Test
    {
        public static string Solution(long[] arr)
        {
            string result = string.Empty;

            if (arr.Length == 0) return result;

            var rootNode = createTree(arr, arr.Length);

            long left = 0;
            calculate(rootNode.left, ref left);

            long right = 0;
            calculate(rootNode.right, ref right);

            if (left > right)
            {
                return "Left";
            }
            else if (left < right)
            {
                return "Right";
            }
            else
            {
                return result;
            }
        }

        public static void calculate(Node node, ref long sum)
        {
            if (node.left == null && node.right == null)
            {
                sum += node.left.key;
            }
            if (node.left != null)
            {
                calculate(node.left, ref sum);
            }
            if (node.right != null)
            {
                calculate(node.right, ref sum);
            }
        }


        public class Node
        {
            public long key;
            public Node left, right;

            public Node(long key)
            {
                this.key = key;
                left = right = null;
            }
        }

        public static Node root;

        public static void createNode(long[] parent, long i, Node[] created)
        {
            if (created[i] != null)
            {
                return;
            }

            created[i] = new Node(i);

            if (parent[i] == -1)
            {
                root = created[i];
                return;
            }

            if (created[parent[i]] == null)
            {
                createNode(parent, parent[i], created);
            }

            Node p = created[parent[i]];

            if (p.left == null)
            {
                p.left = created[i];
            }
            else
            {

                p.right = created[i];
            }
        }

        public static Node createTree(long[] parent, long n)
        {
            Node[] created = new Node[n];
            for (int i = 0; i < n; i++)
            {
                created[i] = null;
            }

            for (int i = 0; i < n; i++)
            {
                createNode(parent, i, created);
            }

            return root;
        }

    }
}
