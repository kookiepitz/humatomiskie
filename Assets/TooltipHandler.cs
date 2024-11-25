using UnityEngine;
using UnityEngine.UI;

public class TooltipHandler : MonoBehaviour
{
    public Canvas tooltipCanvas;
    public Text tooltipText; // Drag the Text component here
    public Vector3 offset = new Vector3(10, 10, 0);

    void Start()
    {
        tooltipCanvas.gameObject.SetActive(false); // Hide tooltip initially
    }

    void Update()
    {
        // Make the tooltip follow the mouse
        if (tooltipCanvas.gameObject.activeSelf)
        {
            tooltipCanvas.transform.position = Input.mousePosition + offset;
        }
    }

    public void ShowTooltip(string message)
    {
        tooltipText.text = message;
        tooltipCanvas.gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        tooltipCanvas.gameObject.SetActive(false);
    }
}


