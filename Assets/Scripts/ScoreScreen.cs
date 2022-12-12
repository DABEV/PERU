using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScreen : MonoBehaviour
{
    private TextMeshProUGUI textcomponent;

    private void Start() {
        textcomponent = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        textcomponent.text = Mathf.Floor(Score.Score2).ToString();

        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("MenuScreeen");
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("PERU");
        }
    }
}
