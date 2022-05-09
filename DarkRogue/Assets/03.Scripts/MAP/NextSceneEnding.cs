using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextSceneEnding : MonoBehaviour
{
	public Animator anim;
	// 재생할 자식 요소 애니메이션 
	public GameObject light;

	void Start()
	{
		light.SetActive(false); // 빛 효과가 켜지는것 방지
	}


    // 플레이어와 충돌 시 빛 애니메이션 재생
    private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			// anim.SetTrigger("FadeIn");
			light.SetActive(true);
			//Invoke("Ending", 2);
		}
		
	}

	
	
	

}
