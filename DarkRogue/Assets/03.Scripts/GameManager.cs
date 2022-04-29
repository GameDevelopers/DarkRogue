using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menuPanel; // �޴� Ŭ���� �г� Ȱ��ȭ
    public bool isPause = false; // �Ͻ����� ����
    
     
  
    public void Startgame()
    {
        
         SoundManager.sm.SelectBtnPlay();
         StartCoroutine(SceneChange());
         //SceneManager.LoadScene(1);
        
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(1.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void HomeMenu()
    {
        
        SoundManager.sm.HomeBtnPlay();
        SceneManager.LoadScene(0);

    }

    public void Exitgame()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }

    // �޴� Ŭ���� ȭ�� �Ͻ����� �� �г� Ȱ��ȭ
    public void OnMenu()
    {
        if (!isPause)
        {   // �Ͻ����� ���� �ƴϸ� �Ͻ�����
            Time.timeScale = 0; // �ð�����
            // �г�Ȱ��ȭ
            menuPanel.SetActive(true);
            Debug.Log("click");
        }
        else
        {
            Time.timeScale = 1.0f; // �ð��帧 ���� 1
            menuPanel.SetActive(false);
        }

        isPause = !isPause; // �޴� ���� ������ ���°� �ݴ�� �ٲ�
    }





}
