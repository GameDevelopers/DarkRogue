using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip HomeBtn;
    public AudioClip SelectBtn;

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

    public void HomeBtnPlay()
    {
        audioSource.PlayOneShot(HomeBtn);
    }
    public void SelectBtnPlay()
    {
        audioSource.PlayOneShot(SelectBtn);
    }








}
