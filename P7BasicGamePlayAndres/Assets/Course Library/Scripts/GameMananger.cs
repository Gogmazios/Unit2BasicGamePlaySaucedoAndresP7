using JetBrains.Annotations;
using UnityEngine;

public class GameMananger : MonoBehaviour
{



    private int score = 0;
    private int lives = 3; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
    }
    

    // Update is called once per frame
    void Update()
    {
      //  if( )
    }

    public void AddLives(int value)
    {
        lives += value; 

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
            Time.timeScale = 0f;
        }
        Debug.Log("Lives = " + lives); 

    }


    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score =" + score); 
    }

}
