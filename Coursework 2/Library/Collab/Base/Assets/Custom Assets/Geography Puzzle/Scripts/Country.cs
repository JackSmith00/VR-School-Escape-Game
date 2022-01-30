using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public string flagCountry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void VRAction()
    {
        GetComponentInParent<Progress>().flagPressed(flagCountry);
    }
}
