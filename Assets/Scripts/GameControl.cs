using UnityEngine;

public class GameControl : MonoBehaviour {

	public static GameControl instance;

	public bool gameOver = false;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	void Update()
	{
		if (gameOver && Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Game Over");
		}		
	}
}
