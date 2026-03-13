using System.Data;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    private float startDelay = 2;
    private float spawnInterval = 1.5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        {

        }
    }





    public GameObject[] animalPrefabs;
    public float spawnRangeX = -30;
    public float spawnPosZ = -30;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    //public int animalIndex; 
    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetKeyDown(KeyCode.S))
       // {
           // SpawnRandomAnimal(); 
            //int animalIndex = Random.Range(0, animalPrefabs.Length);
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

           // Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
     //   }

        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftanimal()
    {
        int animallndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0); 
        Instantiate(animalPrefabs[animallndex], spawnPos, Quaternion.Euler(rotation)); 
    }


    void SpawnRightAnimal()
    {
        int animallndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0); 
        Instantiate(animalPrefabs[animallndex], spawnPos, Quaternion.Euler(rotation)); 
    }
}
