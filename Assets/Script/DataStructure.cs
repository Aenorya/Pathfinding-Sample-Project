using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NodeData
{
    public static int NodeCount = 0;
    public int id;
    public List<Connection> Connections = new List<Connection>();

    public NodeData()
    {
        
    }

    public void Initialize()
    {
        id = NodeCount;
        NodeCount++;
    }
}

[Serializable]
public class Connection
{
    public Node From, To;
    public int weight = 1;
}


[Serializable]
public class Graph
{
    public List<NodeData> nodes = new List<NodeData>();
    public List<Connection> Connections = new List<Connection>();
}