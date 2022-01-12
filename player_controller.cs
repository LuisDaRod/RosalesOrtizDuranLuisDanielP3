using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public bool perdio = false;
    public float speed = 3.0f;

    Rigidbody2D rigidbody2d;
    private AudioSource Audiosource;
    public GameOverScreeb GameOverScreeb;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Audiosource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;

        if (perdio)
        {
            MoveCam mi_camara = (MoveCam) FindObjectOfType<MoveCam>();
            MoveBordes bordes = (MoveBordes)FindObjectOfType<MoveBordes>();

            Audiosource.Play();
            mi_camara.move = false;
            bordes.move = false;
            GameOverScreeb.Setup();

            Destroy(gameObject);
        }
    }

    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "limDerecha" || other.tag == "limIzquierda")
        {
            MoveCam mi_camara = (MoveCam)FindObjectOfType<MoveCam>();
            MoveBordes bordes = (MoveBordes)FindObjectOfType<MoveBordes>();

            mi_camara.CambiarDireccion();
            bordes.CambiarDireccion();
        }
    }

    public void CambiarVelocidad()
    {
        speed = speed + 0.5f;
    }

}
