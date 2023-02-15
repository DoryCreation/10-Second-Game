using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjectOnGrid : MonoBehaviour
{

    public Transform gridCellPrefab;
    public Transform cube;

    [SerializeField] private int height;
    [SerializeField] int width;
    private Node[,] nodes;

    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void CreateGrid()
    {
        nodes= new Node[width, height];
        var name = 0;
        for (int i = 0; i<width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 worldPosition = new Vector3(x: i, y: 0, z: j);
                Transform obj = Instantiate(gridCellPrefab, worldPosition, Quaternion.identity);
                obj.name = "Cell" + name;
                nodes[i, j] = new Node(isPlaceable: true, worldPosition, obj);
                name++;
             }

        }
    }
}

public class Node
{
    public bool isPlaceable;
    public Vector3 cellPosition;
    public Transform obj;

    public Node(bool isPlaceable,Vector3 cellPostion, Transform obj)
    {
        this.isPlaceable = isPlaceable;
        this.cellPosition = cellPosition;
        this.obj = obj;
    }
}
