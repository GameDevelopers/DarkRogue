using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    public GameObject Endding;
    public GameObject light;

    // Start is called before the first frame update
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
