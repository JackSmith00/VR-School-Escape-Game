using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public GameObject DoorLight;
    public GameObject PosterLight;
    private string[] expectedOrder;
    private Queue<string> pressedOrder;

    public GameObject gameCompletionTracker;

    // Start is called before the first frame update
    void Start()
    {
        expectedOrder = new string[] { "Peru", "China", "France", "Egypt" }; // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
        pressedOrder = new Queue<string>(new string[] { "UK", "UK", "UK", "UK" }); // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-6.0
    }

    public void flagPressed(string flag)
    {
        pressedOrder.Enqueue(flag); // add this note to the end of the queue
        pressedOrder.Dequeue(); // remove not from the start of the queue

        if (completedOrder()) // check if melody is complete
        {
            GetComponent<RevealRoomItem>().Reveal(); // show completion object if complete
            DoorLight.GetComponent<ToggleRoomCompleteLight>().GreenLightOn();
            PosterLight.GetComponent<ToggleRoomCompleteLight>().GreenLightOn();

            gameCompletionTracker.GetComponent<GameCompletionTracker>().geoComplete = true;
            gameCompletionTracker.GetComponent<GameCompletionTracker>().CheckCompletion();
        }

    }


    private bool completedOrder()
    {
        string[] playedArray = pressedOrder.ToArray(); // convert queue to array for comparison

        for (int i = 0; i < expectedOrder.Length; i++) // loop through each note
        {
            if (playedArray[i] != expectedOrder[i]) // if any note is inncorrect, melody is not complete
            {
                return false;
            }
        }

        return true; // if no note is incorrect, melody must be complete

    }
}
