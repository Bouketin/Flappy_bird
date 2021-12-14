using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void relaunchGame()
    {
        //relaunch checkpoints, pipes and player
        Player _player = FindObjectOfType<Player>();
        Checkpoint[] _checkpoints = FindObjectsOfType<Checkpoint>();
        Pipe[] _pipes = FindObjectsOfType<Pipe>();

        foreach (Checkpoint item in _checkpoints)
        {
            item.relaunchObject();
        }

        foreach (Pipe _pipe in _pipes)
        {
            _pipe.relaunchObject();
        }

        _player.relaunchObject();

        gameOverPanel.gameObject.SetActive(false);

    }
}
