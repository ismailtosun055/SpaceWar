using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMove : MonoBehaviour
{
    public Transform uzay;
    public Animator anim;
    public float uzayhizi;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal")*uzayhizi*Time.deltaTime;
        float y = Input.GetAxis("Vertical")*uzayhizi*Time.deltaTime;

        uzay.Translate(y,-x,0f);

        if(x != 0 || y != 0){
            anim.SetTrigger("Ucma");
        }
        
    }
}
