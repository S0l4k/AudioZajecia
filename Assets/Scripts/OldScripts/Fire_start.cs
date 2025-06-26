using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Fire_start : MonoBehaviour
{
    public GameObject fireplace;

    private MeshRenderer meshRenderer;

    private void OnTriggerEnter(Collider other)
    {
        fireplace.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        fireplace.SetActive(false);
    }
}
