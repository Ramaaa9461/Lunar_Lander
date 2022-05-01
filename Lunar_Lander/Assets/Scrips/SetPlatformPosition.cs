using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlatformPosition : MonoBehaviour
{
    private RaycastHit hit;
    [SerializeField] Terrain terrain;

    [SerializeField] GameObject[] columns;

    void Start()
    {
        float x = Random.Range(-10, 230);
        float y = 0;
        float z = Random.Range(-10, 230);

        y = terrain.SampleHeight(new Vector3(x, transform.position.y + 10, z));

        transform.position = new Vector3(x, y, z);

    }

}
