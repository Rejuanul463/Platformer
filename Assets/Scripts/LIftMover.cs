using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIftMover : MonoBehaviour {
    public float top, bot;
    private float speed = 7f;
    // Update is called once per frame
    void Update() {
        if (transform.position.y > top) {
            speed = -10f;
        }
        if(transform.position.y < bot)
        {
            speed = 10f;
        }

        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;

        transform.position = pos;
    }
}
