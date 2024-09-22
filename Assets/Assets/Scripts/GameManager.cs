using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

   [SerializeField] private double _clickCount = 0;
   [SerializeField] private double _clickMultiplier = 1; 

   [SerializeField] private double _convertedCount = 0;
   [SerializeField] private TMP_Text _clickCounterTxt;

 public static GameManager Singleton;

 private void Awake()
 {
    Singleton = this; 
 }
 public void OnClick()
{
   _clickCount += _clickMultiplier;

   UpdateText();

   print(_clickCount);
}

private void UpdateText()
{
   if (_clickCount < 100000) {
   _clickCounterTxt.text = _clickCount.ToString();
   }
   
   /// after 100,000 it turns into 100k

   else if (_clickCount >= 100000  && _clickCount < 1000000)
{
   _convertedCount = _clickCount / 1000;
   _clickCounterTxt.text = _convertedCount.ToString("F2") + "K";
}

/// after 1,000,000 it turns into 1M

   else if (_clickCount >= 1000000  && _clickCount < 1000000000)
{  
   _convertedCount = _clickCount / 1000000;
   _clickCounterTxt.text = _convertedCount.ToString("F2") + "M";
}

/// after 1,000,000,000 it turns into 1B

   else if (_clickCount >= 1000000000  && _clickCount < 1000000000000)
{  
   _convertedCount = _clickCount / 1000000000;
   _clickCounterTxt.text = _convertedCount.ToString("F2") + "B";
}

   else if (_clickCount >= 1000000000000  && _clickCount < 1000000000000000)
{  
   _convertedCount = _clickCount / 1000000000000;
   _clickCounterTxt.text = _convertedCount.ToString("F2") + "T";
}




}
}