using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AmbientManager : MonoBehaviour
{
    public static AmbientManager Instance;

    private EventInstance currentAmbient;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public void PlayAmbient(EventReference newAmbient)
    {
        if (currentAmbient.isValid())
        {
            currentAmbient.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            currentAmbient.release();
        }

        currentAmbient = RuntimeManager.CreateInstance(newAmbient);
        currentAmbient.start();
    }

    public void StopCurrentAmbient()
    {
        if (currentAmbient.isValid())
        {
            currentAmbient.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            currentAmbient.release();
        }
    }
}
