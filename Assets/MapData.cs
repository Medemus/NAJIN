using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData
{
    public int Number;
    public List<Vertex> data;
    /// <summary>
    /// 初始化
    /// </summary>
    /// <param name="table"></param>
    public void Anynaz(float num,GameObject table)
    {
        float x_1 = -((num * 128) / 2 - 64) / 100;
        Debug.Log("x_1:" + x_1);
        float y_1 = (num * 128 / 2 - 64) / 100;
        Debug.Log("y_1:" + y_1);
        
        if (data == null)
            data = new List<Vertex>();
        Clear();
        Number = (int)num;
        for (int i = 0,j=0; i < Number*Number; i++)
        {
            Vertex vertex = new Vertex(Plat.PLAT_NORMAL);
            vertex.X = x_1 + j * 1.28f;
            vertex.Y = y_1;
            data.Add(vertex);
            j++;
            if(j==num)
            {
                y_1 -= 1.28f;
                j = 0;
            }
        }
        SetTableAll(table);
    }
    public void SetTableAll(GameObject Block)
    {
        for(int i = 0; i < data.Count; i++)
        {
            GameObject temp = GameObject.Instantiate(Block, new Vector3(data[i].X, data[i].Y, 0), Quaternion.Euler(0, 0, 0));
            data[i].table = temp;
            temp.GetComponent<Plat_S>().vertex = data[i];
        }
    }
    public void Clear()
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i].table != null)
                GameObject.Destroy(data[i].table);
        }
        data.Clear();
    }

}
public enum Plat
{
    PLAT_NULL = 0,
    PLAT_NORMAL = 1,
    PLAT_WALL = 2
}
public enum Enemy
{
    ENEMY_NULL = 0,
    ENEMY_1 = 1
}
public enum Direction
{
    NULL = -1,
    UP = 0,
    LEFT = 1,
    RIGHT = 2,
    DOWN = 3
}
public enum Trap
{
    NULL = 0
}
public enum ChangeKind
{
    Table = 0,
    Enemy = 1,
    Enemy_Dir = 2
}
public class Vertex
{
    public Plat plat;
    public Enemy enemy;
    public Direction direction;
    public Trap trap;
    public float X, Y;//坐标
    public GameObject table;
    public GameObject enemy_object;
    public Vertex(Plat plat)
    {
        this.plat = plat;
        this.enemy = Enemy.ENEMY_NULL;
        this.direction = Direction.NULL;
        this.trap = Trap.NULL;
        this.table = null;
    }
    public void ChangePlatKind(Plat plat)
    {
        this.plat = plat;
        SetPlat();
    }
    public void SetPlat()
    {
        Debug.Log(plat.ToString());
        string path = "Plats/" + plat.ToString();
        Debug.Log(path);
        LoadSprite(path);
    }
    public void SetEnemy(Enemy enemy)
    {
        Debug.Log("SetEnemy");
        if(this.enemy == Enemy.ENEMY_NULL)
        {
            enemy_object =GameObject.Instantiate(Resources.Load("Enemise/" + enemy.ToString()) as GameObject, new Vector3(X, Y, 0), Quaternion.Euler(Vector3.zero));
            
        }
        else
        {
            GameObject.Destroy(enemy_object);
            enemy_object = GameObject.Instantiate(Resources.Load("Enemise/" + enemy.ToString()) as GameObject, new Vector3(X, Y, 0), Quaternion.Euler(Vector3.zero));
        }
        this.enemy = enemy;
    }

    void LoadSprite(string path)
    {
        Texture2D texture2D = (Texture2D)Resources.Load(path);
        Sprite sprite = Sprite.Create(texture2D, table.GetComponent<SpriteRenderer>().sprite.textureRect, new Vector2(0.5f, 0.5f));
        table.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}


