using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject enemy;
    public static gameManager I;

    public Text elapsedTimeInSecondsText;
    public Text endText;

    void Awake()
    {
        I = this;
    }

    float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeEnemy", 0.0f, 0.5f);
    }

    void makeEnemy()
    {
        Instantiate(enemy);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        elapsedTimeInSecondsText.text = time.ToString("N2");
    }

    public void endGame()
    {
        endText.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
