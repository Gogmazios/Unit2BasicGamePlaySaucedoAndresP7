using UnityEditor.Build.Content;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Z axis bounds
    private float ZtopBound = 110;
    private float ZlowerBound = -30;
    //Y axis bounds
    private float YtopBound = 0.1f;
    private float YlowerBound = -0.1f;
    //X axis bounds 
    private float XleftBound = -35;
    private float XrightBound = 35;

    private float sideBound = 30;
    private GameMananger gameManager;

 //   Food_Banana_01
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameMananger>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.name == "Food_Sandwich_01(Clone)")
       // {
        //    if (transform.position.z > lowerBound)
        //    {
        //        Destroy(gameObject);
        //    }
       // }


       // Z bounds
        if (gameObject.name == "Food_Sandwich_01(Clone)")
        {
            if (transform.position.z < ZlowerBound)
            {
                Destroy(gameObject);
            }
        }

        if (gameObject.name == "Food_Banana_01(Clone)")
        {
            if (transform.position.z < ZlowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.z > ZtopBound)
            {
                //Debug.Log("Game Over!");
                gameManager.AddLives(-1); 
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.z > ZtopBound)
            {
                //  Debug.Log("Game Over!");
                gameManager.AddLives(-1);
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.z > ZtopBound)
            {
                // Debug.Log("Game Over!");
                gameManager.AddLives(-1);
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.z > ZtopBound)
            {
                //Debug.Log("Game Over!");
                gameManager.AddLives(-1);
                Destroy(gameObject);
            }
        }

        // Y bounds
        else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.y > YtopBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.y > YtopBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.y > YtopBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.y > YtopBound)
            {
                Destroy(gameObject);
            }
        }








        else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.y > YlowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.y > YlowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.y > YlowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.y > YlowerBound)
            {
                Destroy(gameObject);
            }
        }

        // X axis bounds 

        else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.x > XleftBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.x > XleftBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.x > XleftBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.x > XleftBound)
            {
                Destroy(gameObject);
            }
        }



        else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.x > XrightBound)
            {
                Destroy(gameObject);
                gameManager.AddLives(-1);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.x > XrightBound)
            {
                Destroy(gameObject);
                gameManager.AddLives(-1);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.x > XrightBound)
            {
                Destroy(gameObject);
                gameManager.AddLives(-1);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.x > XrightBound)
            {
                Destroy(gameObject);
                gameManager.AddLives(-1);
            }
        }
























        //else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        // {
        //   if (transform.position.z < lowerBound)
        //  {
        //      Destroy(gameObject);
        // }
        // }

        // else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        // {
        //    if (transform.position.z < topBound)
        //    {
        //       Destroy(gameObject);
        //   }
        //  }

        // else if (gameObject.name == "Chicken-White Variant(Clone)")
        // {
        //    if (transform.position.z < topBound)
        ///   {
        //       Destroy(gameObject);
        //   }
        // }

        /// else if (gameObject.name == "Rooster  Variant(Clone)")
        // {
        //    if (transform.position.z < topBound)
        //    {
        //        Destroy(gameObject);
        //   }
        // }



    }
}
