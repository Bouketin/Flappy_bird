using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * speed;
    }

    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
}
