using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextSceneEnding : MonoBehaviour
{
	public Animator anim;
	// ����� �ڽ� ��� �ִϸ��̼� 
	public GameObject light;

	void Start()
	{
		light.SetActive(false); // �� ȿ���� �����°� ����
	}


    // �÷��̾�� �浹 �� �� �ִϸ��̼� ���
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
