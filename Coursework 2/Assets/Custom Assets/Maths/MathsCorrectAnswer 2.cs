using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* This script is for processing collisions when the player 'collects' the correct answer to the Maths question.
*
* @author Richard Berry
* Last updated: 05/01/2022
*/

public class MathsCorrectAnswer : MonoBehaviour
{
	public GameObject particleEffect;

	public GameObject roomCompleteLightAtDoor;
	public GameObject roomCompleteLightAtPoster;

	public GameObject gameCompletionTracker;



	// Collision detection. if the player enter the trigger, it is 'picked up' by instantiating the 'Pickup' method.

	void VRAction()
	{
		Pickup();
		GetComponent<RevealRoomItem>().Reveal();
		roomCompleteLightAtDoor.GetComponent<ToggleRoomCompleteLight>().GreenLightOn(); // make the room light above door green when room is completed
		roomCompleteLightAtPoster.GetComponent<ToggleRoomCompleteLight>().GreenLightOn(); // make the room light at poster green when room is completed

		gameCompletionTracker.GetComponent<GameCompletionTracker>().mathsComplete = true;
		gameCompletionTracker.GetComponent<GameCompletionTracker>().CheckCompletion();
	}
	
	void Pickup()
	{
		// Prints text when the player collides with the trigger.
		
		print("That is the correct answer. Well done.");
		
		// Spawns particle effects on the object.
		
		Instantiate (particleEffect);
		
		// Removes the object from the scene after the player has collided with it.
		
		Destroy(gameObject);
    }
}
