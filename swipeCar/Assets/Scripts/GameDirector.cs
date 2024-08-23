using System;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject flagGo;
    GameObject carGo;
    GameObject textGo;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        flagGo = GameObject.Find("flag");
        carGo = GameObject.Find("car");
        textGo = GameObject.Find("text");
        text = textGo.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //거리를 출력한다
        double distance = flagGo.transform.position.x - carGo.transform.position.x;
        distance = Math.Round(distance);

        if (distance == 0)
        {
            text.text = "CLEAR!";
        }
        else if (distance < 0)
        {
            text.text = "Game Over";
        }
        else
        {
            text.text = $"거리: {distance}m";
        }
    }
}
