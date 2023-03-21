using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Update is called once per frame
    public void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;

    }

}