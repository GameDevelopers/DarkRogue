using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 아이템 생성될 타입 종류
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

    // 아이템 비용 항목 추가
    public int itemCost;

 
}

