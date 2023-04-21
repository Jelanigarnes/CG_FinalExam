using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaToggle : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<Renderer>().material.SetFloat("_DisplacementStrength", 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<Renderer>().material.SetFloat("_DisplacementStrength", 0.5f);
        }
    }
}
