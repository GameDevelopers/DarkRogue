using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogManager : MonoBehaviour, IPointerDownHandler
{
    public Text dialogText;
    public GameObject nextText;

    public Queue<string> sentences;

    private string currentSentence;
    public float typingSpeed = 0.1f;

    public bool istyping = false;
    public bool skip = false;

    public CanvasGroup dialoggroup;

    // 다른 스크리트에서도 사용할 수 있게 스태틱 처리
    public static DialogManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        sentences = new Queue<string>();    
    }

    public void Ondialog(string[] lines)
    {
        sentences.Clear();
        foreach(string line in lines)
        {
            sentences.Enqueue(line);
        }
        dialoggroup.alpha = 1;
        dialoggroup.blocksRaycasts = true;

        NextSentence();
    }

    public void NextSentence()
    {
        if (sentences.Count != 0)
        {
            currentSentence = sentences.Dequeue();
            //코루틴 타이핑효과
            istyping = true;
            nextText.SetActive(false);
            StartCoroutine(Typing(currentSentence));
        }
        else
        {   // 알파값이 0 이면 비활성화 
            dialoggroup.alpha = 0;
            dialoggroup.blocksRaycasts = false;
            skip = false;
        }
    }

    // 코루틴 글자 하나하나씩 타이핑 되는 느낌으로 재생되도록 문장을 반복문을 이용
    IEnumerator Typing(string line)
    {
        dialogText.text = "";
        foreach( char letter in line.ToCharArray())
        {
            dialogText.text += letter;
            if (skip) yield return null; //한프레임 지연
            else yield return new WaitForSeconds(typingSpeed);
        }
        istyping = false;
    }

    
    void Update()
    {
        // 대사 한줄 끝났는지 확인
        if (dialogText.text.Equals(currentSentence))
        {
            nextText.SetActive(true);
            istyping = false;
        }
    }

    // 타이핑 중이 아니라면 화면 클릭 시 다음 문장 재생
    public void OnPointerDown(PointerEventData eventData)
    {
        if(!istyping)
        NextSentence();
    }


}
