using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject enemyPrefab;
    [SerializeField] private Transform positionA;
    [SerializeField] private Transform positionB;

    private float time;


  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       time = time + Time.deltaTime;

        if (time > 1.0f)
        {
            float x = Random.Range(positionA.position.x, positionB.position.x);
            float z = Random.Range(positionA.position.z, positionB.position.z);
            float y = 1;
            Instantiate(enemyPrefab, new Vector3(x, y, z), enemyPrefab.transform.rotation);
            time = 0f;
        }
    }
    
}
