using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyProgressTracker : MonoBehaviour
{

    private string[] expectedMelody; // holds the melody expected from the player
    private Queue<string> playedMelody; // holds melody played by the player

    public GameObject roomCompleteLightAtDoor;
    public GameObject roomCompleteLightAtPoster;

    public GameObject gameCompletionTracker;


    // Start is called before the first frame update
    void Start()
    {
        expectedMelody = new string[] {"C", "G", "F", "E", "D", "C2", "G"}; // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
        playedMelody = new Queue<string>(new string[] {"H", "H", "H", "H", "H", "H", "H"}); // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-6.0
    }

    /// <summary>
    /// called when a new note is played to determine if the full melody has
    /// been played
    /// </summary>
    /// <param name="note">string value of the note played</param>
    public void NotePlayed(string note)
    {
        playedMelody.Enqueue(note); // add this note to the end of the queue
        playedMelody.Dequeue(); // remove not from the start of the queue

        if (MelodyComplete()) // check if melody is complete
        {
            GetComponent<RevealRoomItem>().Reveal(); // show completion object if complete

            roomCompleteLightAtDoor.GetComponent<ToggleRoomCompleteLight>().GreenLightOn(); // make the room light above door green when room is completed
            roomCompleteLightAtPoster.GetComponent<ToggleRoomCompleteLight>().GreenLightOn(); // make the room light at poster green when room is completed

            gameCompletionTracker.GetComponent<GameCompletionTracker>().musicComplete = true;
            gameCompletionTracker.GetComponent<GameCompletionTracker>().CheckCompletion();


        }

    }

    /// <summary>
    /// Determines if the melody has been completed
    /// </summary>
    /// <returns></returns>
    private bool MelodyComplete()
    {
        string[] playedArray = playedMelody.ToArray(); // convert queue to array for comparison

        for(int i = 0; i < expectedMelody.Length; i++) // loop through each note
        {
            if(playedArray[i] != expectedMelody[i]) // if any note is inncorrect, melody is not complete
            {
                return false;
            }
        }

        return true; // if no note is incorrect, melody must be complete

    }
}
