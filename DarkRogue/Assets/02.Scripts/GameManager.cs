using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// �޴� Ŭ���� �г� Ȱ��ȭ�� ���� UI ������Ʈ
    /// </summary>
    public GameObject menuPanel;

    /// <summary>
    /// �Ͻ����� ����
    /// </summary>
    public bool isPause = false;

    /// <summary>
    /// ùȭ�鿡�� ���� �÷��̷� �Ѿ�� ��ŸƮ 
    /// </summary>
    public void Startgame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(2);
        }
    }

    /// <summary>
    /// ù �ε� ȭ������ �̵�
    /// </summary>
    public void GoZeroScene()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(0);
        }
    }

    /// <summary>
    /// ��������
    /// </summary>
    public void Exitgame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }

    /// <summary>
    /// �޴� ��ư Ŭ���� ȭ�� �Ͻ����� �� �޴� �г� Ȱ��ȭ
    /// </summary>
    public void OnMenu()
    {
        if (!isPause)
        {   // �Ͻ����� ���� �ƴϸ� �Ͻ�����
            Time.timeScale = 0; // �ð�����
            // �г�Ȱ��ȭ
            menuPanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f; // �ð��帧 ���� 1
            menuPanel.SetActive(false);
        }

        isPause = !isPause; // �޴� ���� ������ ���°� �ݴ�� �ٲ�
    }

}
