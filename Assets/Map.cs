using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Plat
{
    PLAT_NULL=0,
    PLAT_NORMAL = 1,
    PLAT_WALL=2
}


public class Vertex
{
    public Plat plat;
    public bool isVisted;
    public Vertex(Plat plat)
    {
        this.plat = plat;
    }
}

public class Map_muis
{
    public int Number;
    public GameObject[] platform;
    
    public Map_muis(int num)
    {
        Number = num;
        
    }
}



/*
public class Graph
{
    public int Number;
    private Vertex[] vertices;
    public int[,] adjmatrix;
    int vernuts = 0;

    public Graph(int num)
    {
        Number = num;
        adjmatrix = new int[Number, Number];
        vertices = new Vertex[Number];
        for(int i = 0;i<Number;i++)
        {
            for(int j = 0;j<Number;j++)
            {
                adjmatrix[i, j] = 0;
            }
        }
    }

   /// <summary>
   /// 增加节点
   /// </summary>
   /// <param name="plat"></param>
   public void ADDvertex(Plat plat)
    {
        vertices[vernuts] = new Vertex(plat);
        vernuts++;
    }

    public void ChangeVertex(Plat plat)
    {

    }

}
*/

public class Map : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
