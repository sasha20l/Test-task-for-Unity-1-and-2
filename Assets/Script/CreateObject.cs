

using UnityEngine;

using System.Collections;

public class CreateObject : MonoBehaviour
{

    public GameObject prefab;
    private bool flagMouseButtonDown1 = true;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && flagMouseButtonDown1)
        {
            var camera = GetComponent<Camera>();
            var mousePos2D = Input.mousePosition;
            var screenToCameraDistance = camera.nearClipPlane;

            var mousePosNearClipPlane = new Vector3(mousePos2D.x, mousePos2D.y, 10);

            var worldPointPos = camera.ScreenToWorldPoint(mousePosNearClipPlane);

            var dot = Instantiate( prefab, worldPointPos, Quaternion.identity);
            dot.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1);
        } 
        else if (Input.GetMouseButtonDown(1) && flagMouseButtonDown1) flagMouseButtonDown1 = false;
        else if (Input.GetMouseButtonDown(1) && !flagMouseButtonDown1) flagMouseButtonDown1 = true;
}   }
