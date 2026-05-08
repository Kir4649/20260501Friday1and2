using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform Player;
    Transform Enmey;

    private float EnemyHP = 1;
    void Start()
    {
        Player player = GetComponent<Player>();
        float distance = Vector3.Distance(Player.position, Enmey.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag ==  "Bullet") 
        {
            Destroy(gameObject);
        }
    }
}
