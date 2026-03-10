using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 110;
    private float lowerBound = 75; 




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Food_Sandwich_01(Clone)")
        {
            if (transform.position.z > topBound)
            {
                Destroy(gameObject);
            }
        }

       else if (gameObject.name == "Chick                 baby chicken Variant(Clone)")
        {
            if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-Brown Variant(Clone)")
        {
            if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Chicken-White Variant(Clone)")
        {
            if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }

        else if (gameObject.name == "Rooster  Variant(Clone)")
        {
            if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }




    }
}
