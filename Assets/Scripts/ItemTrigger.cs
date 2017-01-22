using UnityEngine;

public class ItemTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Sakda")
        {
			gameObject.SetActive(false);
			Energy.instance.Increase(5);
		}
	}
}
