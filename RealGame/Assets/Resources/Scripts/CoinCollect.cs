using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CoinCollect : MonoBehaviour
{
    public int realScore;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            realScore++;
            Destroy(gameObject);
            CoinsManager.Instance.ScoreRate(realScore);
      
        }
    }
}
