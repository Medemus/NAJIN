using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum Plat
{
    PLAT_NULL=0,
    PLAT_NORMAL = 1,
    PLAT_WALL=2
}

[SerializeField]
public class Vertex
{
    [SerializeField]
    public Plat plat;
    [SerializeField]
    public bool isVisted;
    [SerializeField]
    public Vertex(Plat plat)
    {
        this.plat = plat;
    }
}
[SerializeField]
public class Map_muis: ScriptableObject
{
    [SerializeField]
    public int Number;
    [SerializeField]
    public GameObject[] platform;
    [SerializeField]
    public Vertex[] data;
    [SerializeField]
    /// <summary>
    /// 初始化
    /// </summary>
    /// <param name="table"></param>
    public void Anynaz(GameObject table,int num)
    {
        
        Number = num;
        for (int i = 0; i < Number; i++)
        {
            data[i] = new Vertex(Plat.PLAT_NORMAL);
            platform[i] = GameObject.Instantiate(table);
        }
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
    public Map_muis map_;
    public GameObject table;
    // Start is called before the first frame update
    void Start()
    {
        map_.Anynaz(table, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Map_muis Load()
    {
        Map_muis _Muis = Resources.Load("sdada") as Map_muis;
        return _Muis;
    }
}
