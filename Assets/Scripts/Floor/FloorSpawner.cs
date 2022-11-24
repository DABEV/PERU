using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private Vector2 scaleRange;
    [SerializeField] private float offset;

    void Start()
    {
        StartCoroutine("SpawnFloors");
        Time.timeScale = 1f;
    }

    public IEnumerator SpawnFloors()
    {
        while (floor.transform.position.x < FloorMovement.deleteAfter && FloorMovement.continueCreating)
        {
            // Espera N segundos antes de continuar con la secuencia
            yield return new WaitForSeconds(0.55f);

            // Crea un nuevo objeto de platform en el punto de la derecha con la rotación normal
            // Retorna el GameObject de la copia
            GameObject instance = Instantiate(floor, Vector3.right * offset, Quaternion.identity);

            // Crea plataformas de diferentes tamaños
            /*
            instance.transform.localScale = new Vector3(
                Random.Range(scaleRange.x, scaleRange.y),
                instance.transform.localScale.y,
                instance.transform.localScale.x
            );
            */

            // Aumenta en 2% la velocidad del tiempo para la dificultad
            // Time.timeScale *= 1.02f;
        }
    }
}
