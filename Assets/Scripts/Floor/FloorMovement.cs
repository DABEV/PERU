using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    // Velocidad en la cu�l se va a mover la plataforma
    [SerializeField] private float speed = 3f;
    [SerializeField] public static float deleteAfter = -150f;
    [SerializeField] public static bool continueCreating = true;

    // Realiza el movimiento de la plataforma
    // Update is called once per frame
    void Update()
    {
        // Esta plataforma se mueve en x positivo (derecha)
        transform.position += Vector3.back * speed * Time.deltaTime;

        // Si la plataforma se movi� m�s de deleteAfter unidades, entonces destruye el objeto
        if (transform.position.z < deleteAfter)
        {
            float getRanScaZ = Random.Range(FloorSpawner.scaleRangeZ.x, FloorSpawner.scaleRangeZ.y);
            float getRanScaX = Random.Range(FloorSpawner.scaleRangeX.x, FloorSpawner.scaleRangeX.y);

            this.gameObject.transform.position = Vector3.zero;
            this.gameObject.transform.localScale = new Vector3(
                getRanScaZ,
                this.gameObject.transform.localScale.y,
                getRanScaX
            );
            continueCreating = false;
        }
    }
}
