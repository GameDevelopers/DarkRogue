using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 메뉴 클릭시 패널 활성화를 위한 UI 오브젝트
    /// </summary>
    public GameObject menuPanel;

    /// <summary>
    /// 일시정지 상태
    /// </summary>
    public bool isPause = false;

    /// <summary>
    /// 첫화면에서 게임 플레이로 넘어가는 스타트 
    /// </summary>
    public void Startgame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(2);
        }
    }

    /// <summary>
    /// 첫 로딩 화면으로 이동
    /// </summary>
    public void GoZeroScene()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(0);
        }
    }

    /// <summary>
    /// 게임종료
    /// </summary>
    public void Exitgame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }

    /// <summary>
    /// 메뉴 버튼 클릭시 화면 일시정지 및 메뉴 패널 활성화
    /// </summary>
    public void OnMenu()
    {
        if (!isPause)
        {   // 일시정지 중이 아니면 일시정지
            Time.timeScale = 0; // 시간정지
            // 패널활성화
            menuPanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f; // 시간흐름 비율 1
            menuPanel.SetActive(false);
        }

        isPause = !isPause; // 메뉴 누를 때마다 상태가 반대로 바뀜
    }

}
