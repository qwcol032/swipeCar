
using System;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Action onMoveComplete;
    bool isMove = false;
    float speed = 0;

    void Update()
    {

        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -8, 8), -3, 0);
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        if (this.speed < 0.0001 && isMove == true)
        {
            this.onMoveComplete();
            isMove = false;
        }

    }

    public void Move(float speed)
    {
        this.speed = speed;
        isMove = true;
    }
}