using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoNoteTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public string noteStringValue;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    public void VRAction()
    {
        audioSource.Play();
        GetComponentInParent<MelodyProgressTracker>().NotePlayed(noteStringValue);
    }
}
