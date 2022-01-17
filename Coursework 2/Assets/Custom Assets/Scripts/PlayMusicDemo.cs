using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicDemo : MonoBehaviour
{
    public void VRAction()
    {
        GetComponent<AudioSource>().Play(); // Play the audio when pressed
    }
}
