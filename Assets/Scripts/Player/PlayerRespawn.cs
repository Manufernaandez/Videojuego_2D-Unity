using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;

    //Teletransporte al checkpoint
    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    //Se guarda la posici�n al coger el checkpoint
    public void ReachedCheckpoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);
        PlayerPrefs.SetFloat("checkPointPositionY",y);
    }

    //Cuando el Player sufre da�o
    public void PlayerDamaged()
    {
        //Salta el aviso y se resetea la escena
        animator.Play("Da�o");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
