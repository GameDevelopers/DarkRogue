using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    // 풀 지나갈 때 소리 재생 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" )
        {
            SoundManager.sm.GrassmovePlay();
        }
    }
}
