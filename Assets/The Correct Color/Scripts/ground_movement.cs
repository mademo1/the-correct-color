using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_movement : MonoBehaviour
{
    public float ground_velocity;
    // Start is called before the first frame update
    void Start()
    {
        ground_velocity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * -ground_velocity, Space.World);
    }
}
