using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiningPlatform : MonoBehaviour
{
    private float speed = 10f;
    private float rotationZ = 10;
    // Update is called once per frame
    void Update()
    {
        rotationZ -= speed * Time.deltaTime;    
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}
