using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;
    
    //Se abre el panel y se para el tiempo dentro del juego
    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    //Bot�n de volver, se desactiva el panel y vuelve a haber tiempo dentro del juego
    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    //Bot�n de opciones
    public void AnotherOptions()
    {
        //Sound
        //Graphics
    }

    //Bot�n del men� principal, vuelve a haber tiempo y se teletransporta al Player al Main Level
    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Level");
    }

    //Bot�n de cerrar el juego
    public void QuitGame()
    {
        //Solo funciona con el ejecutable
        Application.Quit();
    }
}
