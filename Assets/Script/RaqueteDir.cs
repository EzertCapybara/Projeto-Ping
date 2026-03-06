
using UnityEngine;
using UnityEngine.InputSystem;

public class RaqueteDir : MonoBehaviour
{

    public Vector2 myPosition;
    public float myY;
    public float velocity = 5f;
    public float myLimit = 3.0f;

    void Start()
    {
        myPosition = transform.position;
    }
    void Update()
    {
        float deltaVelocity = velocity * Time.deltaTime;
        myPosition.y = myY;
        transform.position = myPosition;
        Keyboard teclado = Keyboard.current;

        if (teclado.rightArrowKey.isPressed)
        {
            myY = myY + deltaVelocity;
            Debug.Log("TECLA up SENDO PRECIONADA!");
        }

        if (teclado.leftArrowKey.isPressed)
        {
            myY = myY - deltaVelocity;
            Debug.Log("TECLA down SENDO PRECIONADA!");
        }

        if (myY < -myLimit)
        {
            myY = -myLimit;
        }

        if (myY > myLimit)
        {
            myY = myLimit;
        }
    }
}