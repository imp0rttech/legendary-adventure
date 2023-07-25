using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool is_ground;
    
    //check collider == true
    void OnCollisionEnter()
    {
        is_ground = true; 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            is_ground = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 250, 0)); //vector3 2nd param = y 
        }
    }
}