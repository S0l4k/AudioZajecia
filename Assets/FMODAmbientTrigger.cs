using UnityEngine;
using FMODUnity;

public class FMODAmbientTrigger : MonoBehaviour
{
    public EventReference ambientEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AmbientManager.Instance.PlayAmbient(ambientEvent);
        }
    }
}
