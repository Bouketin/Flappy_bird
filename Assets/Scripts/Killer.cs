using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<Player>() != null)
        {
            //p_collision.gameObject.SetActive(false);
            Debug.Log ("DIE");
            FindObjectOfType<UIManager>().triggerGameOver();
        }
        
    }
        
        
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
