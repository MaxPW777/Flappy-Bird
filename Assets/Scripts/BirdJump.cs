using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpstrength = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpstrength;
        }
        transform.rotation = Quaternion.Euler(0,0, rb.velocity.y > 0 ? 16f : -16f);
    }
}
