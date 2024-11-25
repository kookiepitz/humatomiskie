using UnityEngine;

public class PartTooltip : MonoBehaviour
{
    public string Frontalis; 

    private TooltipHandler tooltipHandler;

    void Start()
    {
        tooltipHandler = FindObjectOfType<TooltipHandler>();
    }

    void OnMouseEnter()
    {
        tooltipHandler.ShowTooltip(Frontalis );
    }

    void OnMouseExit()
    {
        tooltipHandler.HideTooltip();
    }
}

