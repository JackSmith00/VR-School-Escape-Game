using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameReveal : MonoBehaviour
{
    public GameObject endMessage;

    public void VRAction()
    {
        endMessage.GetComponent<RevealRoomItem>().Reveal(); // show completion object if complete

        ExecuteAfterTime(5f);
    }

    private void EndGame()
    {
        Application.Quit(); // The reference provided was used / modify to help in the creation of the script. This code will be referenced within the report https://forum.unity.com/threads/ending-game.39709/
    }

    // The reference provided was used / modify to help in the creation of the script. This code will be referenced within the report https://answers.unity.com/questions/796881/c-how-can-i-let-something-happen-after-a-small-del.html
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        EndGame();

    }
}
