using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAT_UI : MonoBehaviour
{
    public Plat plat;
    public Enemy enemy;
    public ChangeKind changeKind;
    public bool canChange;
    private void Awake()
    {
        canChange = false;
    }
    public void cl_Normal()
    {
        plat = Plat.PLAT_NORMAL;
        changeKind = ChangeKind.Table;
        canChange = true;
    }
    public void cl_NULL()
    {
        plat = Plat.PLAT_NULL;
        changeKind = ChangeKind.Table;
        canChange = true;
    }
    public void cl_WALL()
    {
        plat = Plat.PLAT_WALL;
        changeKind = ChangeKind.Table;
        canChange = true;
    }
    public void cl_Cancel()
    {
        canChange = false;
    }
    public void cl_Enemy_1()
    {
        enemy = Enemy.ENEMY_1;
        changeKind = ChangeKind.Enemy;
        canChange = true;
    }
}
