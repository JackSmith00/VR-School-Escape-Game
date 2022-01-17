using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundWord : MonoBehaviour
{
    public GameObject doorLight;
    public GameObject posterLight;

    public GameObject gameCompletionTracker;

    public void VRAction()
    {
        GetComponent<RevealRoomItem>().Reveal();

        doorLight.GetComponent<ToggleRoomCompleteLight>().GreenLightOn();
        posterLight.GetComponent<ToggleRoomCompleteLight>().GreenLightOn();

        gameCompletionTracker.GetComponent<GameCompletionTracker>().engComplete = true;
        gameCompletionTracker.GetComponent<GameCompletionTracker>().CheckCompletion();
    }
}
