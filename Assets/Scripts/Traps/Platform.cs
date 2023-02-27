using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float startWaitTime;
    private float waitedTime;
    
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();

    }

    
    void Update()
    {
       //Se resetea el tiempo de baje de la plataforma
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s"))
        {
            waitedTime = startWaitTime;
        }
        
       //Cuando se pulse la tecla "s" o la flecha hacia abajo
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
           //Se rota el efecto de la plataforma
            if (waitedTime<=0)
            {
                effector.rotationalOffset = 180f;
                waitedTime = startWaitTime;
            }
            else
            {
                waitedTime -= Time.deltaTime;
            }
        }
       //Player baja de la plataforma
        if (Input.GetKey("space"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
