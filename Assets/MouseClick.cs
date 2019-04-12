using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public PLAT_UI PLAT_UI;
    private void Start()
    {
        PLAT_UI = GameObject.Find("PLAT_UI_Manager").GetComponent<PLAT_UI>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Table" && PLAT_UI.canChange)
                {
                    hit.collider.GetComponent<Plat_S>().Clicked = true;
                }
            }
        }
    }
}
