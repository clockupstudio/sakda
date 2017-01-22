using UnityEngine;

public class ItemTrigger : MonoBehaviour {

	public AudioClip collectSound;
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Sakda")
        {
			gameObject.SetActive(false);
			Energy.instance.Increase(5);
			SoundManager.instance.PlaySingle(collectSound);
		}
	}
}
