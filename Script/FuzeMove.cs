using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzeMove : MonoBehaviour
{
    public Rigidbody2D fuze;
    public float fuzehizi;
    public float uzaycan;
    void Start()
    {
        SpaceMove candegeri = FindObjectOfType<SpaceMove>();
        uzaycan = candegeri.f22can;
    }

    void Update()
    {
        fuze.velocity = Vector3.up*fuzehizi*Time.deltaTime;
        Destroy(gameObject,1);
    }

    void OnCollisionEnter2D(Collision2D collision2D){
        Destroy(gameObject);
        uzaycan -= 10;
        Debug.Log(uzaycan);
    }
}
