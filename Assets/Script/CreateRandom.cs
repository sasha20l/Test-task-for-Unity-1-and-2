using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandom : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Cube;
    public int numberOfCubes;

    private float randomX;
    private float randomY;
    private float randomZ;

    private GameObject prefab;


    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            randomX = Random.Range(-20, 20);
            randomY = Random.Range(-10, 10);
            randomZ = Random.Range(0, -19);

            prefab = Instantiate(Cube, new Vector3 (randomX, randomY, randomZ), Quaternion.identity);

            prefab.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
