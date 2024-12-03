using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipHandler1 : MonoBehaviour
{
    public GameObject tooltip; // The tooltip GameObject
    private TextMeshPro textComponent; // Reference to the TextMeshPro component
    private string[] tooltipMessages = { "Tooltip 1", "Tooltip 2", "Tooltip 3" }; // Example tooltip texts
    private int currentIndex = 0; // Keeps track of the current tooltip message index

    void Start()
    {
        // Get the TextMeshPro component attached to the tooltip
        if (tooltip != null)
        {
            textComponent = tooltip.GetComponent<TextMeshPro>();
        }
    }

    // Show the tooltip when hovering over the cube
    public void ShowTooltip()
    {
        if (tooltip != null)
        {
            tooltip.SetActive(true);
        }
    }

    // Hide the tooltip when hover ends
    public void HideTooltip()
    {
        if (tooltip != null)
        {
            tooltip.SetActive(false);
        }
    }

    // Change the tooltip's text when clicked
    public void UpdateTooltipText()
    {
        if (textComponent != null)
        {
            currentIndex = (currentIndex + 1) % tooltipMessages.Length; // Cycle through the tooltip messages
            textComponent.text = tooltipMessages[currentIndex];
        }
    }
}

