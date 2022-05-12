using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    // 애니메이션을 미리 만들어둔 프리팹을 담을 변수 
    public GameObject Endding;
    public GameObject wlight;

    // 엔딩크리딧 애니메이션  실행 방지를 위해 한번 더 꺼져있다는 상태를 작성
    void Start()
    {
        Endding.SetActive(false);
    }

    // 애니메이션에 이벤트 메서드를 이용해서 사용할 메서드(add Event)
    public void OnCredit()
    {
        Endding.SetActive(true);
        wlight.SetActive(false);
    }
}
