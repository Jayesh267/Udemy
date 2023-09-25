using System.Collections;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Udemy
{
    public class TrieNode
    {
        Dictionary<char, TrieNode> children;
        bool endOfString;

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
            endOfString = false;
        }
    }
}