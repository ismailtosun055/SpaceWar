using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtesYerii : MonoBehaviour
{
    public Transform enemyatesyeri;
    public GameObject enemyprefab;
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(enemyprefab,enemyatesyeri.position,Quaternion.identity);
        }
    }

}
