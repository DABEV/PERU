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

        if (transform.position.z < -17f)
        {
            Destroy(this.gameObject);
        }
    }
}
// // Vector3 viewPos = cam.WorldToViewportPoint(target.position);
//         if (viewPos.y > 1F)
//  sceneManager -> hacemos el cambio de escena "puntaje"
//             print("target is on the right side!");
// Link por si hay duda
// aGREAR UN MINIMO DE LA PLATAFORMA PARA QUE ESTE NO SEA MENOR AL TAMAÑO DEL OBJETO
// https://docs.unity3d.com/ScriptReference/Camera.WorldToViewportPoint.html
