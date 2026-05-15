using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    private Vector3 startPos;
    private Rigidbody rb;
    public float forceMultiplier = 10f; // 飛ばす力の倍率

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        // マウスを押した時のワールド座標を取得
        startPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        Debug.Log(startPos);
    }

    void OnMouseUp()
    {
        // マウスを離した時のワールド座標を取得
        Vector3 endPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));

        // 引っ張った方向（ベクトル）を計算
        Vector3 forceDir = startPos - endPos;

        // 力（Force）を加えて飛ばす
        rb.AddForce(forceDir * forceMultiplier, ForceMode.Impulse);
    }
}
