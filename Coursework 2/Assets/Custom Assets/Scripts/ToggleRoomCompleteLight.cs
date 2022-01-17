using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRoomCompleteLight : MonoBehaviour
{

    public GameObject redLight;
    public GameObject greenLight;

    public Material onMaterial;
    public Material offMaterial;

    public void GreenLightOn()
    {
        print("here");

        redLight.GetComponent<MeshRenderer>().material = offMaterial;
        greenLight.GetComponent<MeshRenderer>().material = onMaterial;

        redLight.GetComponent<Light>().enabled = false;
        greenLight.GetComponent<Light>().enabled = true;

    }
}
