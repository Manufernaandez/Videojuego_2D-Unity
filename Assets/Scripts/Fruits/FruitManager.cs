using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

    public Text totalFruits;
    public Text fruitsCollected;

    private int totalFruitsInLevel;
    
    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }
    
    //Cuando se recogen todas las frutas salta el aviso
    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();

    }

    //Cuando se han recogido todas las frutas
    public void AllFruitsCollected()
    {
        //Si el objeto padre tiene 0 hijos, se han recolectado todas
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan más frutas. Has GANADO!!");
            levelCleared.gameObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
