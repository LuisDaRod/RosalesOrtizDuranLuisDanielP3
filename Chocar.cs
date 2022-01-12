using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chocar : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        player_controller player = other.gameObject.GetComponent<player_controller>();
        

        if (player != null)
        {
            player.perdio = true;
            
        }
    }
}
