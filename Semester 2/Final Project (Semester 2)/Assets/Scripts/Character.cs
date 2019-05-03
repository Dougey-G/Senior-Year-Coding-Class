using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public List<Vector3> teleportLocations = new List<Vector3>();

    float jump = 4;
    int jumps = 3;
    float speed = 1028;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Jump Code
        if (Input.GetKeyDown(KeyCode.W) && jumps != 0)
        {
            rbody.velocity += Vector2.up * jump;
            jumps--;
        }

        rbody.velocity = new Vector3(5f, Mathf.Clamp(rbody.velocity.y, -4f, 4f), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumps = 3;
    }
}
