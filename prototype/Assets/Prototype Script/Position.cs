using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject PlayerRobot;

    public Vector3 PlayerRobot_Pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRobot_Pos = PlayerRobot.GetComponent<PlayerRobot>().transform.position; // �� ��ġ���� ������ ������ ������ �ٸ� Ŭ�󿡴ٰ� �Ѹ��� �װ� �ű⼭ �ν��Ͻ��� ���� ��ġ �ϸ� �ɵ� transform.position �Ἥ
    }
}
