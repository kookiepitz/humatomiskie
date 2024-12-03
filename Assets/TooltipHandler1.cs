using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipHandler1 : MonoBehaviour
{
    public GameObject tooltip; // Drag and drop the tooltip GameObject here in the Inspector

    // Function to show the tooltip
    public void ShowTooltip()
    {
        if (tooltip != null)
        {
            tooltip.SetActive(true); // Activate the tooltip
        }
    }

    // Function to hide the tooltip
    public void HideTooltip()
    {
        if (tooltip != null)
        {
            tooltip.SetActive(false); // Deactivate the tooltip
        }
    }
}
