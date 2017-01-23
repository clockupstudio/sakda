using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .1f;
    private SpriteRenderer renderrer;
    private Animator animator;
    private Rigidbody2D body;
    public Wave rightWave;
    public Wave leftWave;
    public GameObject rightAttack;
    public GameObject leftAttack;
    public AudioClip deadSound;

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
            animator.SetTrigger("Walk");
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            renderrer.flipX = false;
            body.velocity = new Vector2(moveSpeed, body.velocity.y);
            animator.SetTrigger("Walk");
        }
        else
        {
            body.velocity = Vector2.zero;
            animator.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (renderrer.flipX)
            {
                leftWave.Fire();
            }
            else
            {
                rightWave.Fire();
            }
        }
    }

    public void StartAttack()
    {
        if (renderrer.flipX)
        {
            leftAttack.gameObject.SetActive(true);
        }
        else
        {
            rightAttack.gameObject.SetActive(true);
        }
    }

    public void StopAttack()
    {
        if (renderrer.flipX)
        {
            leftAttack.gameObject.SetActive(false);
        }
        else
        {
            rightAttack.gameObject.SetActive(false);
        }
    }

    public void Dead()
    {
        animator.SetTrigger("Dead");
        SoundManager.instance.PlaySingle(deadSound);
    }

}
