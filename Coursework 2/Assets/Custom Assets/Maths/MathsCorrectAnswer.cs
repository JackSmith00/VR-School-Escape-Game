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
	
	// Collision detection. if the player enter the trigger, it is 'picked up' by instantiating the 'Pickup' method.
	
	void OnTriggerEnter(Collider other)
	{
		if (other.name == "RigidBodyFPSController")
			Pickup(other);
	}
	
	void Pickup(Collider player)
	{
		// Prints text when the player collides with the trigger.
		print("That is the correct answer. Well done.");
		
		// Removes the object from the scene after the player has collided with it.
		
		Destroy(gameObject);
    }
}
