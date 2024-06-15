using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefapMermi : MonoBehaviour
{
    public Rigidbody2D enemyfuze;
    public float enemyfuzehizi;
    void Start()
    {
        
    }

    void Update()
    {
        enemyfuze.velocity = -Vector3.up*enemyfuzehizi*Time.deltaTime;
        Destroy(gameObject,1);
    }

    void OnCollisionEnter2D(Collision2D collision2D){
        Destroy(gameObject);
    }
}
