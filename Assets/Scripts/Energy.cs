using System;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{

    public float energy = 100f;
    public Text energyText;
    public GameObject gameOverText;

    // Update is called once per frame
    void Update()
    {
        if (energy >= 0)
        {
            energy -= Time.deltaTime * 2f;
        }


        if (energy >= 0)
        {
            energyText.text = String.Format("Energy: {0:0}", energy);
        }

        if (energy < 0)
        {
			GameControl.instance.gameOver = true;
            gameOverText.SetActive(true);
        }

    }
}
