using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageToggle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Sprite defaultImage; 
    public Sprite pressedImage;

    private Image imageComponent;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        imageComponent.sprite = defaultImage; 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        imageComponent.sprite = pressedImage; }

    public void OnPointerUp(PointerEventData eventData)
    {
        imageComponent.sprite = defaultImage;
    }
}
