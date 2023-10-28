using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private GameObject waypointPrefab;

    private void DrawPath(List<Vector3> path)
    {
        foreach (var position in path)
        {
            Instantiate(waypointPrefab, position, Quaternion.identity);
        }
    }
}
