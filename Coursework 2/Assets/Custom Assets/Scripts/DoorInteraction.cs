using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public void VRAction()
    {
        if(transform.rotation.y == 0)
        {
            transform.Rotate(0, 90, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }
}
