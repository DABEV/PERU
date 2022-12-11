using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle" || transform.position.y < -2)
        {
            SceneManager.LoadScene("MenuScreeen");
        }
    }
}
