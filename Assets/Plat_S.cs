using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plat_S : MonoBehaviour
{
    public Vertex vertex;
    public PLAT_UI PLAT_UI;
    public bool Clicked;
    private void Start()
    {
        Clicked = false;
        PLAT_UI = GameObject.Find("PLAT_UI_Manager").GetComponent<PLAT_UI>();
    }
    private void Update()
    {
        if (Clicked)
        {
            if(PLAT_UI.changeKind == ChangeKind.Table)
            {
                vertex.ChangePlatKind(PLAT_UI.plat);
            }
            else if(PLAT_UI.changeKind == ChangeKind.Enemy)
            {
                vertex.SetEnemy(PLAT_UI.enemy);
            }
            Clicked = false;
        }
    }
}
