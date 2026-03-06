
using UnityEngine;
using UnityEngine.InputSystem;

public class RaquetEsq : MonoBehaviour
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

        if (teclado.qKey.isPressed) {
            myY = myY + deltaVelocity;
            Debug.Log("TECLA Q SENDO PRECIONADA!");
        }

        if (teclado.zKey.isPressed)
        {
            myY = myY - deltaVelocity;
            Debug.Log("TECLA Z SENDO PRECIONADA!");
        }
        
        if (myY <- myLimit)
        {
            myY = -myLimit;
        }

        if (myY > myLimit)
        {
            myY = myLimit;
        }
    }
}