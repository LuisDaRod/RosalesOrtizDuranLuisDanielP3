using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopmusic : MonoBehaviour
{
    public AudioSource backgroundAudio;

    void Start()
    {
        backgroundAudio.Play();
    }

    void Update()
    {
        player_controller player = (player_controller)FindObjectOfType<player_controller>();
        if (player.perdio == true)
        {
            backgroundAudio.Stop();
        }
    }
}
