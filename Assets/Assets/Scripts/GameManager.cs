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

    private void Start()
    {
        // Load saved values from PlayerPrefs
        _clickCount = PlayerPrefs.GetFloat("ClickCount", 0f);
        _clickMultiplier = PlayerPrefs.GetFloat("Multiplier", 1f); 
        UpdateText();
    }

    private void OnApplicationQuit()
    {
    
        PlayerPrefs.SetFloat("ClickCount", (float)_clickCount);
        PlayerPrefs.SetFloat("Multiplier", (float)_clickMultiplier);
        PlayerPrefs.Save(); 
    }

    public void OnClick()
    {
        _clickCount += _clickMultiplier;
        UpdateText();
        PlayerPrefs.SetFloat("ClickCount", (float)_clickCount); 
        PlayerPrefs.Save(); 
    }

    private void UpdateText()
    {
        if (_clickCount < 100000)
        {
            _clickCounterTxt.text = _clickCount.ToString();
        }
        else if (_clickCount >= 100000 && _clickCount < 1000000)
        {
            _convertedCount = _clickCount / 1000;
            _clickCounterTxt.text = _convertedCount.ToString("F2") + "K";
        }
        else if (_clickCount >= 1000000 && _clickCount < 1000000000)
        {
            _convertedCount = _clickCount / 1000000;
            _clickCounterTxt.text = _convertedCount.ToString("F2") + "M";
        }
        else if (_clickCount >= 1000000000 && _clickCount < 1000000000000)
        {
            _convertedCount = _clickCount / 1000000000;
            _clickCounterTxt.text = _convertedCount.ToString("F2") + "B";
        }
        else if (_clickCount >= 1000000000000 && _clickCount < 1000000000000000)
        {
            _convertedCount = _clickCount / 1000000000000;
            _clickCounterTxt.text = _convertedCount.ToString("F2") + "T";
        }
    }

    public double ClickCount => _clickCount;

    public double ClickMultiplier
    {
        get { return _clickMultiplier; }
        set 
        { 
            _clickMultiplier = value; 
            PlayerPrefs.SetFloat("Multiplier", (float)_clickMultiplier); 
            PlayerPrefs.Save(); 
        }
    }

    public void ReduceClickCount(double amount)
    {
        _clickCount -= amount; 
        UpdateText();
        PlayerPrefs.SetFloat("ClickCount", (float)_clickCount);
        PlayerPrefs.Save(); 
    }
    public void AddPoints(int points)
{
    _clickCount += points; 
    UpdateText();
}

}
