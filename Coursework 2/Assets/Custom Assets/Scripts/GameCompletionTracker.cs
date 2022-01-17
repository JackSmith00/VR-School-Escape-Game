using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompletionTracker : MonoBehaviour
{
    public bool musicComplete;
    public bool geoComplete;
    public bool ictComplete;
    public bool mathsComplete;
    public bool engComplete;

    public GameObject leftDoor;
    public GameObject rightDoor;

    void Start()
    {
        musicComplete = false;
        geoComplete = false;
        ictComplete = false;
        mathsComplete = false;
        engComplete = false;
    }

    public void CheckCompletion()
    {
        if(musicComplete && geoComplete && ictComplete && mathsComplete && engComplete)
        {
            leftDoor.transform.Translate(1f, 0f, 0f);
            rightDoor.transform.Translate(-1f, 0f, 0f);
        }
    }
}
