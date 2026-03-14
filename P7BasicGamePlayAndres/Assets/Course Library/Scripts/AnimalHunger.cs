using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor.Build.Content;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;


    private GameMananger gameManager;
    private int currentFedAmount = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);


        gameManager = GameObject.Find("GameManager").GetComponent<GameMananger>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        
        if(currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f); 
        }
    }




}
