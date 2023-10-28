
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float timer = 0.2f; // Ставим таймер на 10 секунд
    public float MinimumMovementStep = 0.1f;
    public float MaxMovementStep = 0.5f;

    private float time;
    private float RandomStep;

    private float distanceY;
    private float distanceX;
    private float distanceZ;

    private void Start()
    {
        time = timer;
    }
    void Update()
    {
        
        time -= 1.0f * Time.deltaTime; // Отнимаем от таймера 1 в секунду
        if (time <= 0.0f)
        { // Если таймер пришел к нулю

            RandomStep = Random.Range(MinimumMovementStep, MaxMovementStep);

            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y + RandomStep, gameObject.transform.localScale.z); // Меняем размер объекта
            distanceY = (gameObject.transform.localScale.y);

            if (gameObject.transform.localEulerAngles.x >= 89.0 && gameObject.transform.localEulerAngles.x < 92.0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z == 0) gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, distanceY / 2);
            else if (gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z == 0) gameObject.transform.position = gameObject.transform.position + new Vector3(0, distanceY / 2, 0);
            else if (gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z > -181 && gameObject.transform.localEulerAngles.z < -179
                || gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z > 179 && gameObject.transform.localEulerAngles.z < 181) gameObject.transform.position = gameObject.transform.position + new Vector3(0, -distanceY / 2, 0);
            else if (gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z >= 89.0 && gameObject.transform.localEulerAngles.z < 92.0) gameObject.transform.position = gameObject.transform.position + new Vector3(-distanceY / 2, 0, 0);
            if (gameObject.transform.localEulerAngles.x < -80.0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z == 0
                || gameObject.transform.localEulerAngles.x < 272.0 && gameObject.transform.localEulerAngles.x > 268.0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z == 0) gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -distanceY / 2);
            else if (gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z < -80.0
                || gameObject.transform.localEulerAngles.x == 0 && gameObject.transform.localEulerAngles.y == 0 && gameObject.transform.localEulerAngles.z < 272.0 && gameObject.transform.localEulerAngles.z > 268) gameObject.transform.position = gameObject.transform.position + new Vector3(distanceY / 2, 0, 0);
            time = timer;


        }
    }
}
