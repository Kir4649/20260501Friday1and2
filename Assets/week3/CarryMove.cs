using System.Data;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarryMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Transform grabPoint;
    [SerializeField] private Transform rayPoint;
    [SerializeField] private float rotateSpeed = 20f;

    private float rayDistance = 2f;
    private GameObject grabObj;
    RaycastHit hit;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Ç∑Ç≈Ç…éùÇ¡ÇƒÇ¢ÇÈÇ»ÇÁó£Ç∑
            if (grabObj != null)
            {
                grabObj.GetComponent<Rigidbody>().isKinematic = false;
                grabObj.transform.SetParent(null);
                grabObj = null;

                return;
            }

            // ëOï˚å¸Ç…Ray
            Debug.DrawRay(rayPoint.position, transform.forward * rayDistance, Color.blue, 1f);

            RaycastHit hit;

            if (Physics.Raycast(rayPoint.position, transform.forward, out hit, rayDistance))
            {
                if (hit.collider.CompareTag("Box"))
                {
                    grabObj = hit.collider.gameObject;

                    Rigidbody rb = grabObj.GetComponent<Rigidbody>();

                    rb.isKinematic = true;

                    grabObj.transform.position = grabPoint.position;
                    grabObj.transform.SetParent(grabPoint);
                }
            }
        }
        if (Keyboard.current.eKey.isPressed)
        {
            grabObj.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Keyboard.current.qKey.isPressed)
        {
            grabObj.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
    }
}
