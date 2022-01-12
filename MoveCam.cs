using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float speed = 1.0f;
    public bool move = true;

    public int direction = 1;

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Vector3 position = transform.position;
            position.x = position.x + speed * direction * Time.deltaTime;
            transform.position = position;

        }
        
    }

    public void CambiarDireccion()
    {
        direction = direction * -1;
    }

    public void CambiarVelocidad()
    {
        speed = speed + 0.5f;
    }

}



