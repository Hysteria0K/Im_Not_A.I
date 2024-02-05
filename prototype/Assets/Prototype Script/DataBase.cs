using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    private float PlayerRobot_Speed = 15.0f;

    public float PlayerRobot_Speed_Corrected = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //프레임 60 고정
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRobot_Speed_Corrected = PlayerRobot_Speed * Time.deltaTime;
    }
}
