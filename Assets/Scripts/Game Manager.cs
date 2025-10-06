using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Android;

public class GameManager : MonoBehaviour
{
    GameState state;

    public enum GameState
    {
        PAUSE, GAMEPLAY 
    }


    public void Start()
    {
        state = GameState.GAMEPLAY;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            state = GameState.PAUSE;
        }
        else if (state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.GAMEPLAY;
            }
        }
    }


}
