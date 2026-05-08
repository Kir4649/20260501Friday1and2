using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    //private float bulletspeed = 2.0f;
    private Vector2 moveInput = Vector2.zero;
    private Transform _transform;
    [SerializeField]
    GameObject boll;
    [SerializeField]
    GameObject bulletpoint;
    Rigidbody rb;

    private void Start()
    {

    }
    private void Update()
    {
        var move = new Vector3(moveInput.x, 0f, moveInput.y) * speed * Time.deltaTime;
        transform.Translate(move);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        shot();
    }
    public void shot()
    {
        GameObject Boll = Instantiate(boll, transform.position, Quaternion.identity);
        Rigidbody rb = Boll.GetComponent<Rigidbody>();
        //srb.AddForce(this.transform.forward * bulletspeed);
    }
}
