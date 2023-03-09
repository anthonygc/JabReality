using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lgravitytogg : MonoBehaviour
{
    public Rigidbody _rigidbody;
    // Start is called before the first frame update
    
    void OnCollisionEnter (Collision targetObj)
    {
        if(targetObj.gameObject.tag == "LGlove")
        {
            _rigidbody.useGravity = true;
        }
    }
}
