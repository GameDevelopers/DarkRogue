using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // 오디오 클립 변수
    public AudioSource audioSource; 
    public AudioClip HomeBtn;
    public AudioClip SelectBtn;
    public AudioClip Grassmove;
    public AudioClip UIonoff;
    public AudioClip SceneChangeSound;
    public AudioClip Portalclip;

    #region singleton
    public static SoundManager sm;
    private void Awake()
    {
        if(sm == null)
        {
            sm = this;
            DontDestroyOnLoad(sm);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    // 오디오 재생 메서드들
    public void HomeBtnPlay()
    {
        audioSource.PlayOneShot(HomeBtn);
    }
    public void SelectBtnPlay()
    {
        audioSource.PlayOneShot(SelectBtn);
    }
    public void GrassmovePlay()
    {
        audioSource.PlayOneShot(Grassmove);
    }
    public void UIonoffPlay()
    {
        audioSource.PlayOneShot(UIonoff);
    }
    public void SceneChangeSoundfPlay()
    {
        audioSource.PlayOneShot(SceneChangeSound);
    }
    public void PortalclipPlay()
    {
        audioSource.PlayOneShot(Portalclip);
    }







}
