using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enabledSelectCharacter;
    
    public enum Player {Frog, PinkMan, VirtualGuy, MaskDude};
    public Player playerSelected;
    
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;
    
    //Para cambiar de personaje
    void Start()
    {
        if (!enabledSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch (playerSelected)
            {
                //Se elige el animator y el sprite del Frog
                case Player.Frog:
                    spriteRenderer.sprite = playersRenderer[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;
                //Se elige el animator y el sprite del Pink Man
                case Player.PinkMan:
                    spriteRenderer.sprite = playersRenderer[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                //Se elige el animator y el sprite del Virtual Guy
                case Player.VirtualGuy:
                    spriteRenderer.sprite = playersRenderer[2];
                    animator.runtimeAnimatorController = playersController[2];
                    break;
                //Se elige el animator y el sprite del Mask Dude
                case Player.MaskDude:
                    spriteRenderer.sprite = playersRenderer[3];
                    animator.runtimeAnimatorController = playersController[3];
                    break;
                default:
                    break;
            }
        }
    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case "PinkMan":
                spriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                break;
            case "VirtualGuy":
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case "MaskDude":
                spriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playersController[3];
                break;
            default:
                break;
        }
    }
}
