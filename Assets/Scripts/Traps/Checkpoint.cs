using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //Para activar el respawn
    private void OnTriggerEnter2D(Collider2D collision)
    {
       //Si Player entra en contacto, se guarda el respawn
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerRespawn>().ReachedCheckpoint(transform.position.x, transform.position.y);
            GetComponent<Animator>().enabled = true;
        }
    }
}
