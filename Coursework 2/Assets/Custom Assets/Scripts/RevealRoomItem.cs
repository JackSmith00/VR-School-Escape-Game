using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealRoomItem : MonoBehaviour
{
   public GameObject roomItem;

   public void Reveal()
    {
        roomItem.SetActive(true);
    }

}
