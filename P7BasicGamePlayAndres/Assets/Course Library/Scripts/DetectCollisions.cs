using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private GameMananger gameManager;
    public GameObject animal1;
    public GameObject animal2;
    public GameObject animal3;
    public GameObject animal4; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameMananger>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //turn the chickens into a KFC bucket
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //  Debug.Log("Game Over");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (other.CompareTag("Animal"))
        {
            // gameManager.AddScore(5);
            other.GetComponent<AnimalHunger>().FeedAnimal(1); 
            Destroy(gameObject);
           // Destroy(other.gameObject);
        }

       // else if (other.CompareTag("Food"))
       // {
       //     if (other.CompareTag("Animal"))
        //    {
        ////        Destroy(animal1);
        //////        Destroy(animal2);
        /////////////////////////////        Destroy(animal3);
        ////////////////////////////////////////////////        Destroy(animal4);


        //////////////////////////////////    }
    ///////////////////    }

    }
}
