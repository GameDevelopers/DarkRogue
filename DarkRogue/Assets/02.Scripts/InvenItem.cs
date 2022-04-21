using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ������ ������ Ÿ�� ����
public enum InvenItemType
{
    Equipment,
    Consumables,
    Etc
}

[System.Serializable]
public class InvenItem 
{
    public InvenItemType itemType;
    public string itemName;
    public Sprite itemImage;

    // ������ ��� �׸� �߰�
    public int itemCost;

 
}

