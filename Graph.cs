using System.Collections;
using System.Text;

namespace Udemy
{
    public class Graph
    {
        List<GraphNode> nodeList = new List<GraphNode>();
        int[][] adjacencyMatrix;

        public Graph(List<GraphNode> nodeList)
        {
            this.nodeList = nodeList;
            adjacencyMatrix = new int[nodeList.Count][];
            for (int i = 0; i < nodeList.Count; i++)
            {
                adjacencyMatrix[i] = new int[nodeList.Count];
            }
        }

        public void addUndirectedEdge(int i, int j)
        {
            adjacencyMatrix[i][j] = 1;
            adjacencyMatrix[j][i] = 1;
        }        
    }
}