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

    // 애니메이션에 이벤트 메서드를 이용해서 사용할 메서드(add Event)
    public void OnCredit()
    {
        Endding.SetActive(true);
        light.SetActive(false);
    }
}
