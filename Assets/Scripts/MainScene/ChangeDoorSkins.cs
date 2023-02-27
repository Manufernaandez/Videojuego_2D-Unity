using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorSkins : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor = false;
    public GameObject player;

   //Cuando el Player entra en contacto con el fondo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Se activa el panel con las skins
        if (collision.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    //Cuando Player deja de estar en contacto con el fondo
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Se desactiva el panel
        skinsPanel.gameObject.SetActive(false);
        inDoor = false;
    }

    //Se elige la skin Frog en el panel
    public void SetPlayerFrog()
    {
        //Se cambia a esa skin
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    //Se elige la skin Pink Man en el panel
    public void SetPlayerPinkMan()
    {
        //Se cambia a esa skin
        PlayerPrefs.SetString("PlayerSelected", "PinkMan");
        ResetPlayerSkin();
    }

    //Se elige la skin Virtual Guy en el panel
    public void SetPlayerVirtualGuy()
    {
        //Se cambia a esa skin
        PlayerPrefs.SetString("PlayerSelected", "VirtualGuy");
        ResetPlayerSkin();
    }

    //Se elige la skin Mask Dude en el panel
    public void SetPlayerMaskDude()
    {
        //Se cambia a esa skin
        PlayerPrefs.SetString("PlayerSelected", "MaskDude");
        ResetPlayerSkin();
    }

    //Método para cambia de skin
    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
