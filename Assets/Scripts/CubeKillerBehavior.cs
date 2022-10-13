using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKillerBehavior : MonoBehaviour
{
    // Destroys GameObject on contact if GameObject's tag is "Cube"
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger!");
        GameObject colliderGo = col.gameObject;
        if (colliderGo.tag == "Cube")
        {
            Destroy(colliderGo);
        }
    }
}
