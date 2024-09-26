using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopClickAnim : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private Animator _animator;

    private const string CLICK_TRIGGER = "Click";

    public void OnPointerClick(PointerEventData eventData)
    {

  _animator.SetTrigger(CLICK_TRIGGER);

    }
}
