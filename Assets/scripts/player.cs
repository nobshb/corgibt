using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

    public float moveSpeed = 10f;

    Rigidbody2D _pup;

    // Use this for initialization
    void Start()
    {
        _pup = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newVelocity = new Vector2(0, 0);
        if (Input.GetKey(upKey))
        {
            newVelocity.y += moveSpeed;
        }
        if (Input.GetKey(rightKey))
        {
            newVelocity.x += moveSpeed;
        }
        if (Input.GetKey(downKey))
        {
            newVelocity.y -= moveSpeed;
        }
        if (Input.GetKey(leftKey))
        {
            newVelocity.x -= moveSpeed;
        }

        // Make sure the velocity always has the same magnitude
        newVelocity = newVelocity.normalized * moveSpeed;

        _pup.velocity = newVelocity;
    }
}
