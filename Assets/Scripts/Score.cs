using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float Score2 { get; private set;}
    public Text ScoreText;

    private void Start() {
        Score2 = 0f;
    }

    private void Update()
    {
        Score2 += Time.deltaTime;
        ScoreText.text = Mathf.Floor(Score2).ToString();
    }
}
