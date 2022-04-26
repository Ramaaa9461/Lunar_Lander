using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem up;

    [SerializeField] ParticleSystem forward;
    [SerializeField] ParticleSystem back;
    [SerializeField] ParticleSystem left;
    [SerializeField] ParticleSystem rigth;

    void Start()
    {
       // allEffectsStop();
    }
    public void UpPlay()
    {
        up.Play();
    }
    public void UpStop()
    {
        up.Stop();
    }

    public void ForwardPlay()
    {
        forward.Play();
    }
    public void ForwardStop()
    {
        forward.Stop();
    }

    public void BackPlay()
    {
        back.Play();
    }
    public void BackStop()
    {
        back.Stop();
    }

    public void RigthPlay()
    {
        rigth.Play();
    }
    public void RigthStop()
    { 
        rigth.Stop();
    }

    public void LeftPlay()
    {
        left.Play();
    }
    public void LeftStop()
    {
        left.Stop();
    }


    public void allEffectsPlay()
    {
        up.Play();
        back.Play();
        left.Play();
        rigth.Play();
        forward.Play();
    }
    public void allEffectsStop()
    {
        up.Stop();
        back.Stop();
        left.Stop();
        rigth.Stop();
        forward.Stop();
    }
}
