using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    public Transform atesetmeyeri;
    public GameObject prefab;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Instantiate(prefab,atesetmeyeri.position,Quaternion.identity);
        }
    }

}
