using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;






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

public class Map_Editor : MonoBehaviour
{

    public GameObject table;
    //public GameObject map_data;
    public MapData Data;
    // Start is called before the first frame update
    void Start()
    {
        Data = new MapData();
        Data.Anynaz(2,table);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Data.Anynaz(2,table);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Data.Anynaz(3, table);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Data.Anynaz(4, table);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Data.Anynaz(5, table);
        }

    }

    /*public Map_muis Load()
    {
        //TextAsset _map = Resources.Load("dsdas") as TextAsset;
        Map_muis map_Muis = Resources.Load("Maps/") as Map_muis;
        
        
        return _Muis;
    }*/
}
