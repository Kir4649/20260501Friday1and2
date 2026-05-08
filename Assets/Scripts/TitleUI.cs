using UnityEngine;

public class TitleUI : MonoBehaviour
{

    private void Start()
    {
        // 現在のステートを確認
        if(GameManager.instance.currentState != State.Title)
        {
            GameManager.instance.currentState = State.Title;
        }
    }
    /// <summary>
    /// スタートボタンを押された時
    /// </summary>
    public void OnStartButton(int mode = 0)
    {
        GameManager.instance.gameMode = mode;
        GameManager.instance.stateEnd = true;
    }
}
