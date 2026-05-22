using UnityEngine;
using UnityEngine.InputSystem;

public class GunBullet : MonoBehaviour
{
    private void Update()
    {

        //マウス取得
        Vector2 mousePos = Mouse.current.position.ReadValue();

        Vector3 screenPos = new Vector3(mousePos.x, mousePos.y, 10f);

        Vector3 target = Camera.main.ScreenToViewportPoint(screenPos);
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        // ボタンを押した瞬間
        if (context.performed)
        {
            Debug.DrawRay(gameObject.transform.position, Vector3.up * 6, Color.blue, 0.1f);

            // マウス位置取得
            Vector2 mousePos = Mouse.current.position.ReadValue();

            // Ray作成
            Ray ray = Camera.main.ScreenPointToRay(mousePos);

            RaycastHit hit;

            // Raycast判定
            if (Physics.Raycast(ray, out hit))
            {

                //Destroy(hit.collider.gameObject);
            }
        }
    }
}
