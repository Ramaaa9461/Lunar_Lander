using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject ship;
    [SerializeField] Vector3 offSet;
    [SerializeField] float height = 5;

    void Update()
    {
        if (ship)
        {
            transform.position = ship.transform.position;
            transform.rotation = Quaternion.Euler(25, ship.transform.eulerAngles.y, 0);
            transform.Translate(Vector3.forward * 2 + offSet, Space.Self);
        }
    }
}
