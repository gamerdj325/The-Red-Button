using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    [SerializeField] private GameObject tooltipPanel;
    [SerializeField] private TMP_Text tooltipText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltipPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipPanel.SetActive(false);
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 tooltipPosition = new Vector3(mousePosition.x + 25, mousePosition.y - tooltipPanel.GetComponent<RectTransform>().rect.height - -17, 0);
        tooltipPanel.transform.position = tooltipPosition;
    }

    public void SetTooltipText(string text)
    {
        tooltipText.text = text;
    }
}
