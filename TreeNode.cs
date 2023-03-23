using System;
namespace Udemy
{
    public class TreeNode
    {
        String data;
        List<TreeNode> children;

        public TreeNode(string data)
        {
            this.data = data;
            this.children = new List<TreeNode>();
        }

        public void addChild(TreeNode node)
        {
            this.children.Add(node);
        }

        public String print(int level)
        {
            String ret;
            //ret = " ".repeat(level)+data+"\n";
            ret = new string(' ', level) + data + "\n";
            foreach (TreeNode node in this.children)
            {
                ret += node.print(level + 1);
            }
            return ret;
        }

    }
}