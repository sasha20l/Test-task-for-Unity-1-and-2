
using UnityEngine;

public class Button_Cont : MonoBehaviour
{
    // Start is called before the first frame update

    public string NameLevel;
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)| Input.GetKeyUp(KeyCode.Space))
        {
            Application.LoadLevel(NameLevel);
        }
    }
}
