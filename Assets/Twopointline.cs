using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Twopointline : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    [SerializeField]
    private LineRenderer line;  // You can assign this in the inspector

    // Start is called before the first frame update
    void Start()
    {
       
        if (line == null)
        {
            line = GetComponent<LineRenderer>();

            // If LineRenderer still isn't found, add one to the GameObject
            if (line == null)
            {
                Debug.LogWarning("LineRenderer component not found. Adding one now.");
                line = gameObject.AddComponent<LineRenderer>();  // Adds LineRenderer if missing
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Ensure there are only 2 points in the LineRenderer
        line.positionCount = 2;
        line.SetPosition(0, pointA.position);
        line.SetPosition(1, pointB.position);
    }

    public void setVisible() => gameObject.SetActive(true);
    public void setHide() => gameObject.SetActive(false);
}
