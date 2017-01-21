using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .1f;
    private SpriteRenderer renderrer;
    private Animator animator;
    private Rigidbody2D body;
    // Use this for initialization
    void Start()
    {
        renderrer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (GameControl.instance.gameOver)
        {
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            renderrer.flipX = true;
            body.velocity = new Vector2(-moveSpeed, body.velocity.y);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            renderrer.flipX = false;
            body.velocity = new Vector2(moveSpeed, body.velocity.y);
        }
        else {
            body.velocity = Vector2.zero;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
    }

    public void StartAttack()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void StopAttack()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

}
