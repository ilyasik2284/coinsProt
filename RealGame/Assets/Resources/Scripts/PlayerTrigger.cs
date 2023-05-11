using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private int _realScore;
    private int _Big = 2;
    private int _Small = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SmallCoin"))
        {
            _realScore = _realScore + _Small;
            Destroy(other.gameObject);
            CoinsManager.Instance.ScoreRate(_realScore);
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BigCoin"))
        {
            if (Input.GetKey((KeyCode.E)))
            {
                _realScore +=  _Big;
                Destroy(other.gameObject);
                CoinsManager.Instance.ScoreRate(_realScore);
            }
        }
    }

}
