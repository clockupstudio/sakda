using System;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{

    private float time = 100f;
    public Text energyText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime * 2f;
		energyText.text = String.Format("Energy: {0:0}", time);
    }
}
