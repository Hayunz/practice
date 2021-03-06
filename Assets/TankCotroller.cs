using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCotroller : MonoBehaviour
{
    public int playerNum=1;

    string mvAxisName;
    string rotAxisName;

    float tkMvSpeed = 10.0f;        // 탱크의 이동 속도
    float tkRotSpeed = 150.0f;      // 탱크의 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        mvAxisName= "Vertical"+ playerNum;
        rotAxisName = "Horizontal"+ playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis (mvAxisName) * tkMvSpeed * Time.deltaTime;
        float rot = Input.GetAxis (rotAxisName) * tkRotSpeed * Time.deltaTime;
  
        transform.Translate (0 , 0 , mv);
        transform.Rotate (0 , rot , 0);
    }
}
