using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirCam : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        MoveCam mi_camara = (MoveCam)FindObjectOfType<MoveCam>();
        MoveBordes bordes = (MoveBordes)FindObjectOfType<MoveBordes>();

        if (mi_camara != null)
        {
            mi_camara.CambiarVelocidad();
            bordes.CambiarVelocidad();

            player_controller player = other.gameObject.GetComponent<player_controller>();
            player.CambiarVelocidad();
        }
    }
}
