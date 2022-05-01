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
        allEffectsStop();
    }

    public void rigthFire(KeyCode keyPrincipal, KeyCode keyAlternative)
    {
        if (Input.GetKeyDown(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            RigthPlay();
        }
        if (Input.GetKeyUp(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            RigthStop();
        }
    }
    public void leftFire(KeyCode keyPrincipal, KeyCode keyAlternative)
    {
        if (Input.GetKeyDown(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            LeftPlay();
        }
        if (Input.GetKeyUp(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            LeftStop();
        }
    }
    public void ForwardFire(KeyCode keyPrincipal, KeyCode keyAlternative)
    {
        if (Input.GetKeyDown(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            ForwardPlay();
        }
        if (Input.GetKeyUp(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            ForwardStop();
        }
    }
    public void BackFire(KeyCode keyPrincipal, KeyCode keyAlternative)
    {
        if (Input.GetKeyDown(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            BackPlay();
        }
        if (Input.GetKeyUp(keyPrincipal) || Input.GetKey(keyAlternative))
        {
            BackStop();
        }
    }


    public void UpPlay()
    {
        up.Play();
    }
    public void UpStop()
    {
        up.Stop();
    }

    void ForwardPlay()
    {
        forward.Play();
    }
    void ForwardStop()
    {
        forward.Stop();
    }

    void BackPlay()
    {
        back.Play();
    }
    void BackStop()
    {
        back.Stop();
    }

    void RigthPlay()
    {
        rigth.Play();
    }
    void RigthStop()
    {
        rigth.Stop();
    }

    void LeftPlay()
    {
        left.Play();
    }
    void LeftStop()
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
