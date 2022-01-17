using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for the flash light within game, attached to the player, it has a fucntion of being turned
//off and on using key "F"


public class Flashlight : MonoBehaviour

{
    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightActive = false; //This functions decides whether the flashlight on or off


    // Start is called before the first frame update
    void Start()
    {
        FlashlightLight.gameObject.SetActive(false);
    }




    // Update is called once per frame
    void Update()
    { //These embedded if statements allow the F key to turn on and to turn off using boolean.
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (FlashlightActive == false)
            {
                FlashlightLight.gameObject.SetActive(true);
                FlashlightActive = true;
            }
            else
            {
                FlashlightLight.gameObject.SetActive(false);
                FlashlightActive = false;
            }
        }
        //Referenced code - https://www.youtube.com/watch?v=vRKrg9Ku8Aw


    }
}
