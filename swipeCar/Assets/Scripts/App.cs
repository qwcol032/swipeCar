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
            Debug.Log("자동차 이동완료");
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이를 처음 속도로 변환한다
            car.Move(swipeLength / 1000.0f);
        }
    }

    void ClearGame()
    {
        Debug.Log("게임 클리어!");
    }
}
