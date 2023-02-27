using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigeSpike : MonoBehaviour
{
    //Cuando Player entra en contacto con el enemigo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Se resetea la escena de nuevo
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
