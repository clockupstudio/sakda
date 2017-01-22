using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .1f;
    private SpriteRenderer renderrer;
    private Animator animator;
    private Rigidbody2D body;
    public Wave rightWave;
    public Wave leftWave;

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
        else {
            body.velocity = Vector2.zero;
            animator.SetTrigger("Idle");
        }
    }
    void Update()
    {
        if (GameControl.instance.gameOver)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }

        if(Input.GetKeyDown(KeyCode.Z)){
            if( renderrer.flipX ){
                leftWave.Fire();
            }else{
                rightWave.Fire();
            }
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

    public void Dead(){
        animator.SetTrigger("Dead");
    }

}
