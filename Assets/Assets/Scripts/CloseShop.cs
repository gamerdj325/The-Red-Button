using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CloseShop : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private AudioSource _sfxPlayer;  
    public void OnPointerClick(PointerEventData eventData)
    {
       transform.parent.gameObject.SetActive(false);
       _sfxPlayer.Play();
    }
}


