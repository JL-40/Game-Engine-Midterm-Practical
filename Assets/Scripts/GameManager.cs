using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        if (score >= 20)
        {
            LoseGame();
        }
    }

    public void Score()
    {
        score++;
    }

    public void LoseGame()
    {
        Application.Quit();

    }
}
