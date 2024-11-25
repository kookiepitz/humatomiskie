using System;
using UnityEngine;

[ExecuteInEditMode]
public class twopointline: MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (pointA && pointB && line)
        {
            line.positionCount = 2;
            line.SetPosition(0, pointA.position);
            line.SetPosition(1, pointB.position);
        }
    }

    public void setVisible()
    {
        Debug.Log("Set Visible");
        gameObject.SetActive(true);
    }

    public void setHide()
    {
        Debug.Log("Set Hide");
        gameObject.SetActive(false);
    }

    void OnMouseEnter()
    {
        setVisible();
    }

    void OnMouseExit()
    {
        setHide();
    }
}