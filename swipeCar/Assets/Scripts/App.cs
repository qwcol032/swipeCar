using UnityEngine;

public class App : MonoBehaviour
{
    Vector2 startPos;
    Vector2 endPos;
    CarController car;

    // Start is called before the first frame update
    void Start()
    {
        GameObject carGo = GameObject.Find("car");
        GameObject dirGo = GameObject.Find("GameDirector");
        car = carGo.GetComponent<CarController>();

        car.onMoveComplete = () =>{
            Debug.Log("�ڵ��� �̵��Ϸ�");
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ�
            car.Move(swipeLength / 1000.0f);
        }
    }

    void ClearGame()
    {
        Debug.Log("���� Ŭ����!");
    }
}
