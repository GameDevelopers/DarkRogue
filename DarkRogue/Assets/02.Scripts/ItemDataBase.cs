using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public static ItemDataBase instance;

    //지불수단 변수
    public int money = 0;

    private void Awake()
    {
        instance = this;
    }
    public List<InvenItem> itemDB = new List<InvenItem>();

    // 프리팹 복제 생성을 위한 변수
    public GameObject fielditemPrefab;
    

    // 아이템 습득 확인
    private void Start()
    {
        // 돈 초기값 입력
        money = 0;
         
    }

}
