using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
