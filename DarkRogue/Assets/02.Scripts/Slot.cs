using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour
{
    // ������ ���� ����
    public int slotnum;

    // ������ , �̹��� ���� ����
    public InvenItem item;
    public Image itemIcon;

    // ���̸� �ǸŸ��, �����̸� ������ �����
    public bool isShopMode;
    // �������� ���õǸ� ������ �ٲ� ok������ �� ���� �����۸� �Ǹŵǵ��� ����
    public bool isSell = false;
    // isSell�� ���̸� üũǥ�� �������� ������ش�.
    public GameObject chkSell;

    public void UppdateSlotUI()
    {
        // itemIcon sprite�� ������ �̹����� �ʱ�ȭ�ϰ� Ȱ��ȭ �����ش�.
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);

    }

    // item�� null�� SetActive�� false�� �����ش�
    public void RemoveSlot()
    {
        item = null;
        itemIcon.gameObject.SetActive(false);
    }


    // �Ǹ��� ������
    public void SellItem()
    {   // isSell �� ���̸� ������DB�� �Ӵ� ������ �������� ��븸ŭ ������Ų��
        if (isSell)
        {
            ItemDataBase.instance.money += item.itemCost; // ������ ��ũ��Ʈ�� ���� �ۼ�
            Inventory.instance.RemoveItem(slotnum); // ���� ��ȣ�� �������� ����
            // isSell �ʱ�ȭ
            isSell = false;
            chkSell.SetActive(isSell);
        }
    }

    // �ǸŸ� ���ϰ� ������ �����ϸ� ���õ� ������ ����
    private void OnDisable()
    {
        isSell = false;
        chkSell.SetActive(isSell);
    }
}
