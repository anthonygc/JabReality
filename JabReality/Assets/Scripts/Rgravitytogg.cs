using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rgravitytogg : MonoBehaviour
{
    public Rigidbody _rigidbody;
    
    void OnCollisionEnter (Collision targetObj)
    {
        if(targetObj.gameObject.tag == "RGlove")
        {
            _rigidbody.useGravity = true;
        }
    }
}
