using UnityEngine;

public class Wave : MonoBehaviour {

	private float waveDuration = 0f;
	public float decreaseFactor = 1.0f;
	void Update () {
		if(waveDuration > 0) {
			waveDuration -= Time.deltaTime * decreaseFactor;
		}
		else {
			gameObject.SetActive(false);
		}
	}
	public void Fire(){
		gameObject.SetActive(true);
		waveDuration = .4f;
	}
}
