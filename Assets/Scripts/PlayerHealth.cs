using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject canvas;
    private Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            canvas.SetActive(true);
            transform.position = pos;
            gameObject.SetActive(false);
        }
    }
}
