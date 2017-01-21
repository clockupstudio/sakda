using UnityEngine;

public class BuildingTower : MonoBehaviour
{
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SakdaAttack")
        {
            animator.SetTrigger("Destroy");
        }
    }
}
