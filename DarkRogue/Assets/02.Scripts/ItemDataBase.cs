using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public static ItemDataBase instance;

    //���Ҽ��� ����
    public int money = 0;

    private void Awake()
    {
        instance = this;
    }
    public List<InvenItem> itemDB = new List<InvenItem>();

    // ������ ���� ������ ���� ����
    public GameObject fielditemPrefab;
    

    // ������ ���� Ȯ��
    private void Start()
    {
        // �� �ʱⰪ �Է�
        money = 0;
         
    }

}
