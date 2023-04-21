using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloomToggle : MonoBehaviour
{
    public List<Material> materials = new List<Material>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }

    }
}
