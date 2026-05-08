using UnityEngine;

public class GameUI : MonoBehaviour
{
    private void Start()
    {
        if(GameManager.instance == null)
        {
            return;
        }
        if (GameManager.instance.currentState != State.Game)
        {
            GameManager.instance.currentState = State.Game;
        }
    }
    public void OnToResultButton()
    {
        if (GameManager.instance == null)
        {
            return;
        }
        GameManager.instance.stateEnd = true;
    }
}
