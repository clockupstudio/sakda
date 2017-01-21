using UnityEngine;

public class Sakda : MonoBehaviour
{
    public float moveSpeed = .1f;
    private SpriteRenderer renderrer;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        renderrer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if (GameControl.instance.gameOver) {
			return;
		}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }

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

    public void StartAttack()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void StopAttack()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

}
