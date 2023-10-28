using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingCylinder : MonoBehaviour
{
    public GameObject Cylinder;
    // Start is called before the first frame update

    private float randomX = 1;
    private float randomZ = 1;

    void Start()
    {

        while (randomX == 1 && randomZ == 1 || randomX == -90 && randomZ == -90 || randomX == -90 && randomZ == 90 || randomX == 90 && randomZ == -90)
        {
            randomX = Random.value >= 0.5f ? 0 : 90;
            randomX = Random.value >= 0.5f ? randomX * -1 : randomX;

            randomZ = Random.value >= 0.5f ? 0 : 90;
            randomZ = Random.value >= 0.5f ? randomZ * -1 : randomZ;
        }

        if (randomX == 90 && randomZ == 90)
        {
            randomX = 0;
            randomZ = -180;
        }




        var prefab = Instantiate(Cylinder, transform.position, Quaternion.Euler(randomX, 0, randomZ));
        prefab.GetComponent<Renderer>().material.color = gameObject.GetComponent<Renderer>().material.color;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
