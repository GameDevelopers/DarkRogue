using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    // �ִϸ��̼��� �̸� ������ �������� ���� ���� 
    public GameObject Endding;
    public GameObject light;

    // ����ũ���� �ִϸ��̼�  ���� ������ ���� �ѹ� �� �����ִٴ� ���¸� �ۼ�
    void Start()
    {
        Endding.SetActive(false);
    }

    // �ִϸ��̼ǿ� �̺�Ʈ �޼��带 �̿��ؼ� ����� �޼���(add Event)
    public void OnCredit()
    {
        Endding.SetActive(true);
        light.SetActive(false);
    }
}
