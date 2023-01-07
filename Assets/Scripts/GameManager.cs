using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameState CurrentState;

    void Start()
    {
        CurrentState = GameState.Gameplay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum GameState
    {
        Gameplay,
        Cinematic
    }
}