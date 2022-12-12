using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    public static float MaxScoreNumber { get; private set;}
    public TextMeshProUGUI MaxText;
    // Start is called before the first frame update
    void Start()
    {
        MaxText = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.Score2 > MaxScoreNumber){
            MaxScoreNumber = Score.Score2;
        }
        MaxText.text = "Mejor puntaje: "+Mathf.Floor(MaxScoreNumber).ToString();
    }
}
