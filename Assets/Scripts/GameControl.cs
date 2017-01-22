using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl instance;
    public int buildingCount = 10;
    public Text buildingCountText;
    public GameObject gameClearedText;
    public bool gameOver = false;
    public bool gameCleared = false;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if ((gameOver || gameCleared) && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void DecreaseBuidingCount()
    {
        buildingCount--;
        buildingCountText.text = String.Format("Buildings: {0:0}", buildingCount);

        if (buildingCount <= 0)
        {
            GameControl.instance.gameOver = true;
            gameClearedText.SetActive(true);
            Energy.instance.Stop();
            gameCleared = true;
        }
    }
}
