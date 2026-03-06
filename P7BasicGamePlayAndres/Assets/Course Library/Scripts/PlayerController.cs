using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15; 
    // Update is called once per frame
    void Update()
    {
        //player movement 
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); 

        //keep player in bounds because reasons I guess or something like that 
        //SPINOSAURUS 
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }

        //Launch sandwhich 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
