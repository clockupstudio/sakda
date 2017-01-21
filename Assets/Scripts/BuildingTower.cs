using UnityEngine;

public class BuildingTower : MonoBehaviour
{
    public AudioClip destroyedSound;
    private Animator animator;
    private bool isDestroyed = false;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(isDestroyed){
            return;
        }

        if (other.tag == "SakdaAttack")
        {
            isDestroyed = true;
            animator.SetTrigger("Destroy");
            CameraControl.instance.shakeDuration = 0.04f;
            SoundManager.instance.PlaySingle(destroyedSound);
        }
    }
}
