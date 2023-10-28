using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject prefab;
    public GameObject label;

    public float MinTimer = 0.7f;
    public float MaxTimer = 3.0f;
    private float RandomTimer;
    private float LocalPositionY;
    // Start is called before the first frame update
    void Start()
    {
        RandomTimer = Random.Range(MinTimer, MaxTimer);
    }

    // Update is called once per frame
    void Update()
    {
        RandomTimer -= 1.0f * Time.deltaTime; // Отнимаем от таймера 1 в секунду
        if (RandomTimer <= 0.0f)
        {
            gameObject.GetComponent<Movement>().enabled = false;
            prefab = Instantiate(prefab, label.transform.position, Quaternion.identity);
            prefab.GetComponent<Renderer>().material.color = gameObject.GetComponent<Renderer>().material.color;
            enabled = false;
        }
    }
}
