using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public float speed;

    public Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
            FindObjectOfType<Score>().addScore();
        }

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
