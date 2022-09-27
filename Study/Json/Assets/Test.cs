using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// 1. ������(�ڵ� = Ŭ����)�� ��������. => ������ ������ ����
// 2. �� �����͸� Json���� ��ȯ.(�ù���ڷ� ����)
//==================================================
// 3. Json(�ù�)�� �ٽ� ������ �ڵ�� �ٲٴ� ���
// ���̽�(�ù�) -> ������ -> Ŭ����(�ڵ�)

class Data
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill1;
    // ��Ÿ ���...
}

public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "200��", level = 200, coin = 200, skill1 = false };
    //�̷��� ���� �� ����
    //�ƴϸ� �ٷ� Ŭ�������� �����ϱ�

    // Start is called before the first frame update
    void Start()
    {
        //player.nickname = "200��";
        //�̷� ������ �����Ϳ� ���� �ְų�
        //�� ó�� ���� �� ����


        string JsonData = JsonUtility.ToJson(player);
        //�̷��� Json���� ��ȯ�� �� ����
        //Json�� string���̴�.

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
