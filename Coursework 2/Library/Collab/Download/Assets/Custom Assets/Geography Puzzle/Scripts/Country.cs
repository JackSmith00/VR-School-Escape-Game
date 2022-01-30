using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string flagCountry; //creates a public variable that can be modified in unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void VRAction()
    {
        GetComponentInParent<Progress>().flagPressed(flagCountry); //gets the progress script and pass flagCountry into the flagPressed method
    }
}
