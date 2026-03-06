
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{

    public Rigidbody2D myRB;
    private Vector2 MyVelocity;
    public float velocity = 9f;
    public bool jogando;
    private gameManager gManagerScript;
    public AudioClip som1;
    public AudioClip som2;

    void Start()
    {

        gManagerScript = GameObject.Find("GameManager").GetComponent<gameManager>();

        int direcao = Random.Range(0, 4);

        if (direcao == 0)
        {
            MyVelocity.x = velocity;
            MyVelocity.y = velocity;
        }

        else if (direcao == 1)
        {
            MyVelocity.x = -velocity;
            MyVelocity.y = velocity;
        }

        else if (direcao == 2)
        {
            MyVelocity.x = -velocity;
            MyVelocity.y = -velocity;
        }

        else if (direcao == 3)
        {
            MyVelocity.x = velocity;
            MyVelocity.y = -velocity;
        }
        myRB.linearVelocity = MyVelocity;

        jogando = true;

    }
        void Update()
        {
            Keyboard keyboard = Keyboard.current;
            if (keyboard.spaceKey.isPressed && !jogando)
            {
                Start();

            }
        }


        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "RightWall")
            {
                myRB.linearVelocity = Vector2.zero;
                transform.position = Vector3.zero;
                jogando = false;
            gManagerScript.point1 += 1;
        }

            if (other.gameObject.tag == "LeftWall")
            {
                myRB.linearVelocity = Vector2.zero;
                transform.position = Vector3.zero;
                jogando = false;
            gManagerScript.point2 += 1;
            }
        }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "parede")
        {
            AudioSource.PlayClipAtPoint(som2, transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(som1, transform.position);
        }
    }
}