using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopClickAnim : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private AudioSource _sfxPlayer;
    [SerializeField] private Animator _animator;

    private const string CLICK_TRIGGER = "Click";

    public void OnPointerClick(PointerEventData eventData)
    {

  _sfxPlayer.Play();
  _animator.SetTrigger(CLICK_TRIGGER);
  
    }
}
