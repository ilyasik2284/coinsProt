using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public static CoinsManager Instance;
    [SerializeField] private TextMeshProUGUI _MyText;
    private int _score;

    void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        _MyText.text = "Score: " + _score;
    }

    public void ScoreRate(int _score)
    {
        this._score = _score;
        _MyText.text = _score.ToString();

    }
  
}
