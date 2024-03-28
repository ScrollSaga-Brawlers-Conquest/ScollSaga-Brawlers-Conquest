using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public Camera MainCamera;
    public Camera FinishCamera;

    
    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObj = collision.gameObject;
        MainCamera.enabled = false;
        FinishCamera.enabled = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject otherObj = collider.gameObject;
        MainCamera.enabled = false;
        FinishCamera.enabled = true;
    }
}