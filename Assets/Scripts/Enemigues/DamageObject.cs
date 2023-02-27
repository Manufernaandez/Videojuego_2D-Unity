using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    //Cuando Player entra en contacto con el obstáculo
    private void OnCollisionEnter2D(Collision2D collision)
    {
       //Si entra en contacto se teletransporta al respawn
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
