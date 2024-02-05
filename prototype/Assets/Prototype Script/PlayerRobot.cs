using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRobot : MonoBehaviour
{
    public GameObject DataBase;

    private float speed = 0.0f;

    private bool up = false;
    private bool down = false;
    private bool right = false;
    private bool left = false;

    private bool up_check = false;
    private bool down_check = false;
    private bool right_check = false;
    private bool left_check = false;

    private float Vertical = 0.0f;
    private float Horizontal = 0.0f;

    public Vector3 location = new Vector3(0, 0, 0);

    Rigidbody2D rigid2D;


    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetUpdate();
        Get_Location();
        Move();
    }

    private void GetUpdate()
    {
        speed = DataBase.GetComponent<DataBase>().PlayerRobot_Speed_Corrected;
    }

    private void Get_Location()
    {
        Get_Key();

        if (up == false && down == false) Vertical = 0.0f;
        if (right == false && left == false) Horizontal = 0.0f;

        if (up == true && up_check == false)
        {
            Vertical = 1.0f;
            up_check = true;
        }

        if (down == true && down_check == false)
        {
            Vertical = -1.0f;
            down_check = true;
        }

        if (right == true && right_check == false)
        {
            Horizontal = 1.0f;
            right_check = true;
        }

        if (left == true && left_check == false)
        {
            Horizontal = -1.0f;
            left_check = true;
        }

        location = new Vector3(Horizontal, Vertical, 0);
    }

    private void Get_Key()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
            down = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            up = false;
            up_check = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
            up = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            down = false;
            down_check = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
            right = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
            left_check = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
            left = false;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
            right_check = false;
        }
    }

    private void Move()
    {
        rigid2D.MovePosition(transform.position + location * speed);
    }
}
