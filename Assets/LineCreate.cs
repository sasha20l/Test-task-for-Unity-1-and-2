using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreate : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject motherDot;
    protected LineRenderer  line;
    private bool lineActiveflag = false;
    private Vector3 position;
    private float positionZ;
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = Random.Range(0.1f, 1);
        line.endWidth = line.startWidth;
        line.material.color = gameObject.GetComponent<Renderer>().material.color;

        motherDot = GameObject.FindGameObjectWithTag("dot");

        positionZ = Random.Range(10000, 13000)/1000;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !lineActiveflag)
        {
            
            lineActiveflag = true;
            line.enabled = true;
        }
        else if (Input.GetMouseButtonDown(1) && lineActiveflag)
        {
            lineActiveflag = false;
            line.enabled = false;
        }
        if (lineActiveflag) lineActive();

    }
    private void lineActive()
    {
        position = motherDot.transform.position;
        line.SetPosition(0, new Vector3(transform.position.x, transform.position.y, 10));
        line.SetPosition(1, new Vector3(position.x, position.y, positionZ));
    }

}
