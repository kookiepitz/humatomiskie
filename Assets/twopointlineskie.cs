using UnityEngine;

public class twopointlineskie : MonoBehaviour
{
    // Points for drawing a line
    public Transform pointA; // Assign in the Inspector or dynamically
    public Transform pointB; // Assign in the Inspector or dynamically

    // Update is called once per frame
    void Update()
    {
        // Ensure both pointA and pointB are assigned
        if (pointA == null || pointB == null)
        {
            Debug.LogWarning("pointA or pointB is not assigned! Please assign them in the Inspector or dynamically.");
            return; // Exit Update to avoid errors
        }

        // Draw a line between pointA and pointB in the Scene view
        Debug.DrawLine(pointA.position, pointB.position, Color.red);
    }

    // Method to make the object visible (hover entered)
    public void SetVisible()
    {
        gameObject.SetActive(true); // Enable this GameObject
        Debug.Log("Object is now visible.");
    }

    // Method to hide the object (hover exited)
    public void SetHide()
    {
        gameObject.SetActive(false); // Disable this GameObject
        Debug.Log("Object is now hidden.");
    }
}

