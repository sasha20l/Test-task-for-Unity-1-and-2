using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {

        GameObject[] objectsForLook = GameObject.FindGameObjectsWithTag("dot"); // �����, ���� ����������� ��� ������� � ����� "Birds"

            for (int i = 1; i < objectsForLook.Length; i++)
            { // ������������ � ����� �������� �� ������
                




            }

        }

    }
}
