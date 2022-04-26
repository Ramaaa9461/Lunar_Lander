using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem up;

    void Start()
    {
        UpStop();
    }
    public void UpPlay()
    {
        up.Play();
    }
    public void UpStop()
    {
        up.Stop();
    }
}
