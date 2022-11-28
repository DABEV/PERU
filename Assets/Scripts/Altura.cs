using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altura : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject platform;
    [SerializeField] private Vector2 scaleRange;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("altura");
    }

    public IEnumerator altura()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            GameObject instance = Instantiate(platform, Vector3.zero, Quaternion.identity);
            instance.transform.localScale = new Vector3(
                3,    Random.Range(1,8),0.6f
            );


        }


    }
}
