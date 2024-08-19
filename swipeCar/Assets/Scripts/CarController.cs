using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {

    }

    void Update()
    {
        // �������� ���̸� ���Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ�
            this.speed = swipeLength / 1000.0f;

            // ȿ������ ���
            GetComponent<AudioSource>().Play();
        }

        if (transform.position.x < -8)
        {
            this.speed = 0;
            this.transform.position = new Vector3(-8, -3, 0);
        }

        if(transform.position.x > 8)
        {
            this.speed = 0;
            this.transform.position = new Vector3(8, -3, 0);
        }

        transform.Translate(this.speed, 0, 0);  // �̵�
        this.speed *= 0.98f;                    // ����
    }
}