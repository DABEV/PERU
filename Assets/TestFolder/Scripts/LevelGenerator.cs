using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    public GameObject Tile5;
    public GameObject Tile6;
    public GameObject Tile7;
    public GameObject StartTile;

    private float Index = 0;

    private void Start()
    {
        GameObject StartPlane1 = Instantiate(StartTile, transform);
        StartPlane1.transform.position = new Vector3(0, 0, 7);
        GameObject StartPlane2 = Instantiate(StartTile, transform);
        StartPlane2.transform.position = new Vector3(0, 0, 15);
        GameObject StartPlane3 = Instantiate(StartTile, transform);
        StartPlane3.transform.position = new Vector3(0, 0, 23);
        GameObject StartPlane4 = Instantiate(StartTile, transform);
        StartPlane4.transform.position = new Vector3(0, 0, 31);

        Time.timeScale = 1f;
    }

    private void Update()
    {
        gameObject.transform.position -= new Vector3(0, 0, 10f * Time.deltaTime);

        if(transform.position.z <= Index)
        {
            int RandomInt1 = Random.Range(0, 7);

            if(RandomInt1 == 1)
            {
                GameObject TempTile1 = Instantiate(Tile1, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }
            else if(RandomInt1 == 0)
            {
                GameObject TempTile1 = Instantiate(Tile2, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }else if(RandomInt1 == 2)
            {
                GameObject TempTile1 = Instantiate(Tile3, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }else if(RandomInt1 == 3)
            {
                GameObject TempTile1 = Instantiate(Tile4, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }else if(RandomInt1 == 4)
            {
                GameObject TempTile1 = Instantiate(Tile5, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }else if(RandomInt1 == 5)
            {
                GameObject TempTile1 = Instantiate(Tile6, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }else if(RandomInt1 == 6)
            {
                GameObject TempTile1 = Instantiate(Tile7, transform);
                TempTile1.transform.position = new Vector3(0, 0, 39);
            }

            int RandomInt2 = Random.Range(0, 7);

            if(RandomInt2 == 1)
            {
                GameObject TempTile2 = Instantiate(Tile1, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }
            else if(RandomInt2 == 0)
            {
                GameObject TempTile2 = Instantiate(Tile2, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }else if(RandomInt2 == 2)
            {
                GameObject TempTile2 = Instantiate(Tile3, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }else if(RandomInt2 == 3)
            {
                GameObject TempTile2 = Instantiate(Tile4, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }else if(RandomInt2 == 4)
            {
                GameObject TempTile2 = Instantiate(Tile5, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }else if(RandomInt2 == 5)
            {
                GameObject TempTile2 = Instantiate(Tile6, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }else if(RandomInt2 == 6)
            {
                GameObject TempTile2 = Instantiate(Tile7, transform);
                TempTile2.transform.position = new Vector3(0, 0, 47);
            }

            Index = Index - 15.95f;

            Time.timeScale *= 1.005f;
        }
    }
}
