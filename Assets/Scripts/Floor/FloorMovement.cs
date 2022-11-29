using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    // Velocidad en la cuál se va a mover la plataforma
    [SerializeField] private float speed = 10f;
    [SerializeField] public static float deleteAfter = 150f;
    [SerializeField] public static bool continueCreating = true;

    // Realiza el movimiento de la plataforma
    // Update is called once per frame
    void Update()
    {
        // Esta plataforma se mueve en x positivo (derecha)
        transform.position += Vector3.right * speed * Time.deltaTime;

        // Si la plataforma se movió más de deleteAfter unidades, entonces destruye el objeto
        if (transform.position.x > deleteAfter)
        {
            this.gameObject.transform.position = Vector3.zero;
            this.gameObject.transform.localScale = new Vector3(
                Random.Range(FloorSpawner.scaleRange.x, FloorSpawner.scaleRange.y),
                this.gameObject.transform.localScale.y,
                this.gameObject.transform.localScale.z
            );
            continueCreating = false;
        }
    }
}
