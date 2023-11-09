using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPause : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        MusicPlayer.Play();
    }

}
