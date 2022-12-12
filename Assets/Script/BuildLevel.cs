using UnityEngine;

public class BuildLevel : MonoBehaviour
{
    public Vector2Int gridDimensions;
    public GameObject tilePrefab;
    public Transform gridParent;

    //private List<List<Node>> nodes = new List<List<Node>>();
    public Node[,] graph;
    void Start()
    {
        graph = new Node[gridDimensions.x, gridDimensions.y];
        
        for (int x = 0; x < gridDimensions.x; x++)
        {
            for (int z = 0; z < gridDimensions.y; z++)
            {
                GameObject tile = Instantiate(tilePrefab, gridParent);
                tile.transform.localPosition = new Vector3(x, 0, z);
                graph[x, z] = tile.GetComponent<Node>();
            }
        }
        InitConnections();
    }

    void InitConnections()
    {
        // for ()
        // {
        //     
        // }
    }

    void Update()
    {
        
    }

}
