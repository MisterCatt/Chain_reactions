using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject cube;


    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - cube.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        transform.position = cube.transform.position + offset;
    }
}
