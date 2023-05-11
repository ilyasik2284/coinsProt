using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public static CoinsManager Instance;
    [SerializeField] private TextMeshProUGUI MyText;
    private int score;

    void Start()
    {
        Instance = this;
    }

    private void Update()
    {
          MyText.text = "Score: " + score;
    }

    public void ScoreRate(int score)
    {
        this.score += score;
        MyText.text = score.ToString();
    }
  
}
