using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneEnding : MonoBehaviour
{
	//// ���� ���̵� ó��
	//public GameObject Fade;
	//public Animator Fadeout;

	//public GameObject lighting; // �� �ִϸ��̼�
	//public Animator Light;
	

	//public GameObject enddingCredit; // ����ũ����
	//public Animator Endding;
	//public bool isEnd = false;

    private void Start()
    {
		//Light = lighting.GetComponent<Animator>();
		//Endding = enddingCredit.GetComponent<Animator>();
		//Fadeout = Fade.GetComponent<Animator>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

		//if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.UpArrow))
		//{
		//	lighting.SetActive(true);
		//	Light.SetTrigger("light");

		//}

		//if (collision.tag == "Player" && isEnd == true)
		//{
		//	enddingCredit.SetActive(true);
		//	Endding.SetBool("End", true);
		//}

		//if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.KeypadEnter) && isEnd == true)
		//{
		//	SceneManager.LoadScene("Menu");
		//}

	}

}
