using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernAmbient : MonoBehaviour
{
    public FMODUnity.EventReference fmodEvent;

    public StudioEventEmitter emitter;

    void Start()
    {
        emitter = gameObject.AddComponent<StudioEventEmitter>();
        emitter.Event = "event:/Master/Tavern ambient";
        emitter.Play();
    }
}
