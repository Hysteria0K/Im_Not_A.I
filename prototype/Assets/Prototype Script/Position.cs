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
        PlayerRobot_Pos = PlayerRobot.GetComponent<PlayerRobot>().transform.position; // 이 위치값을 서버로 보내면 서버가 다른 클라에다가 뿌리면 그걸 거기서 인스턴스로 만들어서 위치 하면 될듯 transform.position 써서
    }
}
