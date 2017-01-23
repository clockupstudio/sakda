using System;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public float energy = 100f;
    public Text energyText;
    public GameObject gameOverText;
	public AudioClip alertSound;
	public static Energy instance;
	public Sakda sakda;
	private bool isStop = false;
    void Awake(){
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
    void FixedUpdate()
    {
    	if( isStop || GameControl.instance.gameOver ){
			return;
		}

		if (energy >= 0)
        {
            energy -= Time.deltaTime * 2f;
        }

        if (energy >= 0)
        {
            energyText.color = Color.white;
			energyText.text = String.Format("Energy: {0:0}", energy);
        }

		if (energy < 10) {
			energyText.color = Color.red;
		}

        if (energy < 0)
        {
            GameControl.instance.gameOver = true;
            gameOverText.SetActive(true);
			sakda.Dead();
        }
    }
	public void Stop(){
		isStop = true;
	}
	public void Increase(int amount){
		energy += amount;
	}
}
