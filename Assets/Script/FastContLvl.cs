
using UnityEngine;

public class FastContLvl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool NextLevel;
    public string NameLevel;
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (NextLevel == true)
        {
            Application.LoadLevel(NameLevel);
        }
    }
}
