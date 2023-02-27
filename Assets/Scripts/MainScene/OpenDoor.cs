using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{

    public Text text;
    public string levelName;
    private bool inDoor = false;

    //Cuando el Player entra en contacto con el fondo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se activa el texto
        if (collision.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    //Cuando el Player deja de estar en contacto con el fondo
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Se desactiva el texto
        text.gameObject.SetActive(false);
        inDoor = false;
    }

    //Cuando Player está en contacto con el fondo y se pulsa la "e"
    private void Update()
    {
        //Se teletransporta al nivel elegido
        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
