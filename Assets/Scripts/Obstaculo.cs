using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * 5f * Time.deltaTime;

        if (transform.position.z < -30f)
        {
            Destroy(this.gameObject);
        }
    }
}
