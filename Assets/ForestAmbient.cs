using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestAmbient : MonoBehaviour
{
    public FMODUnity.EventReference fmodEvent;

    public StudioEventEmitter emitter;

    void Start()
    {
        emitter = gameObject.AddComponent<StudioEventEmitter>();
        emitter.Event = "event:/Master/Foresst ambient";
        emitter.Play();
    }
}
