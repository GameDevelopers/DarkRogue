using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorani : MonoBehaviour
{
    public int doorhp = 2;
    private Animator animator;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && doorhp < 0)
        {
            --doorhp;
        }

        else if (doorhp <= 0)
        {
            SoundManager.sm.doorclipPlay();
            animator.SetTrigger("Crash");
         
        }

   

    }


}
