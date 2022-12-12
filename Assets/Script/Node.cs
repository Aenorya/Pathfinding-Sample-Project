using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public NodeData data;
    public List<Connection> Connections;

    public void Awake()
    {
        data.Initialize();
        gameObject.name = data.id.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
