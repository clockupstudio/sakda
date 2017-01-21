using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .5f;
    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = (Vector2)transform.position - new Vector2(moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = (Vector2)transform.position + new Vector2(moveSpeed, 0);
        }
    }
}
