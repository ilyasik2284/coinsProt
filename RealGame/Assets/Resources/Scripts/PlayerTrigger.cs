using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private int realScore;
    private int Big = 2;
    private int Small = 1;
    private int Third;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("BigCoin"))
        {
            realScore += Big;
            Destroy(other.gameObject);
            CoinsManager.Instance.ScoreRate(realScore);

        } else if (other.gameObject.CompareTag("SmallCoin"))
        {
            realScore = realScore + Small;
            Destroy(other.gameObject);
            CoinsManager.Instance.ScoreRate(realScore);
        }


    }
}
