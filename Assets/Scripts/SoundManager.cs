using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;
	public AudioSource sfxSource;
	void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	public void PlaySingle(AudioClip sound){
		sfxSource.clip = sound;
		sfxSource.Play();
	}
}
