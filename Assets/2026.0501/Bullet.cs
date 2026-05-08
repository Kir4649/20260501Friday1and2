using System.Data;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 1f;
    Rigidbody rb;
    private float bulletspeed = 10.0f;
    private void Start()
    {
        Destroy(gameObject, time);
        Rigidbody rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       transform.Translate(this.transform.forward * bulletspeed * Time.deltaTime);
    }
}
