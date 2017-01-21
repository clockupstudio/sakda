using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .5f;
    private Rigidbody2D body;
	private SpriteRenderer renderrer;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
		renderrer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			renderrer.flipX = true;
            transform.position = (Vector2)transform.position - new Vector2(moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
			renderrer.flipX = false;
            transform.position = (Vector2)transform.position + new Vector2(moveSpeed, 0);
        }
    }
}
