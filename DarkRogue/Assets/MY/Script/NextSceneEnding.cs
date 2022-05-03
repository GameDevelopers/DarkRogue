using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneEnding : MonoBehaviour
{
	public Animator anim;

	public GameObject lighting; // �� �ִϸ��̼�
	public GameObject enddingCredit; // ����ũ����


	private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			SceneManager.LoadScene("Menu");
		}

		if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.UpArrow))
		{
			lighting.SetActive(true);

		}
	}

}
