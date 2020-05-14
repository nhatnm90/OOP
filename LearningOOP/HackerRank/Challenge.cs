using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class Challenge
    {
        public static string Solution(long[] arr)
        {
            string result = string.Empty;

            if (arr.Length == 0) return result;

            var tree = BuildTree(arr);

            var left = tree.Where(x => x.IsLeft).Select(x => x.Value).Sum();
            var right = tree.Where(x => !x.IsLeft).Select(x => x.Value).Sum();

            if (left > right)
            {
                return "Left";
            }
            else if (left < right)
            {
                return "Right";
            }
            else {
                return result;
            }
        }

        internal static List<Node> BuildTree(long[] arr)
        {
            var listNode = new List<Node>();
            int isLeftGreater = -1;
            Node rootNode = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    continue;
                }
                if (rootNode == null)
                {
                    rootNode = new Node(arr[i]);
                    rootNode.IsRoot = true;
                    listNode.Add(rootNode);
                    continue;
                }
                if (isLeftGreater == -1)
                {
                    if (arr[i] > rootNode.Value)
                    {
                        isLeftGreater = 1;
                    }
                    else
                    {
                        isLeftGreater = 0;
                    }
                }
                if (isLeftGreater == 1)
                {
                    if (arr[i] > rootNode.Value)
                    {
                        listNode.Add(new Node(arr[i], true));
                    }
                    else
                    {
                        listNode.Add(new Node(arr[i], false));
                    }
                }
                else
                {
                    if (arr[i] > rootNode.Value)
                    {
                        listNode.Add(new Node(arr[i], false));
                    }
                    else
                    {
                        listNode.Add(new Node(arr[i], true));
                    }
                }

            }
            return listNode;
        }

        internal class Node
        {
            public Node(long val, bool isLeft)
            {
                this.Value = val;
                this.IsLeft = isLeft;
            }
            public Node(long val)
            {
                this.Value = val;
            }

            public long Value { get; set; }
            public bool IsRoot { get; set; }
            public bool IsLeft { get; set; }
        }
    }
}
