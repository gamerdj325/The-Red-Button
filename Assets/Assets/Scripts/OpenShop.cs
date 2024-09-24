using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Open : MonoBehaviour
{

public GameObject Shop;

public void OpenPanel() {

    if(Shop != null) 
    {
    bool isActive = Shop.activeSelf;

    Shop.SetActive(!isActive);

    }

}

}

