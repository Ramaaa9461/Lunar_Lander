using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 direction = Vector3.zero;
    Vector3 rotation = Vector3.zero;
    Rigidbody RG;
    [SerializeField] float upForce;
    [SerializeField] FireEffects FireEffects;

    [SerializeField] float speed = 5f;
    private void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (!RG)
        {
            FireEffects.allEffectsPlay();
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
    }
    void FixedUpdate()
    {
        Controls();
        EfectsFireInput();
    }

    void Controls()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direction = transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction = -transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direction = transform.right * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direction = -transform.right * speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            direction.y += upForce;
            FireEffects.UpPlay();
        }
        else
        {
            FireEffects.UpStop();
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.RightControl))
        {
            rotation.y = -1;
        }
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Keypad0))
        {
            rotation.y = 1;
        }

        RG.AddForce(direction, ForceMode.Acceleration);
        transform.Rotate(rotation);

        direction = Vector3.zero;
        rotation = Vector3.zero;
    }

    void EfectsFireInput()
    {
        FireEffects.BackFire(KeyCode.W, KeyCode.UpArrow);
        FireEffects.ForwardFire(KeyCode.S, KeyCode.DownArrow);
        FireEffects.leftFire(KeyCode.D, KeyCode.RightArrow);
        FireEffects.rigthFire(KeyCode.A, KeyCode.LeftArrow);

    }
}
