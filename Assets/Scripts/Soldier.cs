using UnityEngine;

public class Soldier : MonoBehaviour {

	private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SakdaWalk" || other.tag == "SakdaAttack")
        {
			body.velocity = new Vector2(body.velocity.x, -1f);
        }
    }
}
