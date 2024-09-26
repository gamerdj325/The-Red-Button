using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Multiplier : MonoBehaviour, IPointerClickHandler
{
    private int clickCount = 0;
    [SerializeField] private TMP_Text pointsToRemoveText;

    private void Start()
    {
        clickCount = PlayerPrefs.GetInt("MultiplierClickCount", 0);
        UpdatePointsToRemoveText(10 * Mathf.Pow(2, clickCount));
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        double pointsToRemove = 10 * Mathf.Pow(2, clickCount);
        
        if (GameManager.Singleton.ClickCount >= pointsToRemove)
        {
            GameManager.Singleton.ClickMultiplier += 1;
            GameManager.Singleton.ReduceClickCount(pointsToRemove);
            clickCount++;
            PlayerPrefs.SetInt("MultiplierClickCount", clickCount);
            PlayerPrefs.Save();
        }

        UpdatePointsToRemoveText(pointsToRemove);
    }

    private void UpdatePointsToRemoveText(double points)
    {
        pointsToRemoveText.text = "Cost: " + points.ToString();
    }
}
