using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneEnding : MonoBehaviour
{
	public Animator anim;
	// 재생할 자식 요소 애니메이션 
	public GameObject light;

	void Start()
	{
		light.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			// anim.SetTrigger("FadeIn");
			light.SetActive(true);
		}
		if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			SceneManager.LoadScene(0);
        }
	}

	
	

}
