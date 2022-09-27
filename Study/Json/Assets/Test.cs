using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// 1. 데이터(코드 = 클래스)를 만들어야함. => 저장할 데이터 생성
// 2. 그 데이터를 Json으로 변환.(택배상자로 포장)
//==================================================
// 3. Json(택배)를 다시 원래의 코드로 바꾸는 방법
// 제이슨(택배) -> 조립도 -> 클래스(코드)

class Data
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill1;
    // 기타 등등...
}

public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "200원", level = 200, coin = 200, skill1 = false };
    //이렇게 넣을 수 있음
    //아니면 바로 클래스에서 선언하기

    // Start is called before the first frame update
    void Start()
    {
        //player.nickname = "200원";
        //이런 식으로 데이터에 값을 넣거나
        //위 처럼 넣을 수 있음


        string JsonData = JsonUtility.ToJson(player);
        //이러면 Json으로 변환이 된 것임
        //Json은 string형이다.

        //print(JsonData);
        Data player2 =JsonUtility.FromJson<Data>(JsonData);
        print(player2.nickname);
        print(player2.level);
        print(player2.coin);
        print(player2.skill1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
