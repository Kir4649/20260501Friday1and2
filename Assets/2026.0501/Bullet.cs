using System.Data;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float time = 1f;


    private void Start()
    {
        Destroy(gameObject, time);
    }
    void Update()
    {
            
    }
}
