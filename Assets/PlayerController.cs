using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float delta = 0;

    // 화면에 보일 때, 처음 실행되는 함수
    // 한번만 실행됩니다.
    void Start()
    {
        
    }

    // Update is called once per frame
    // 매 프레임 실행되는 함수
    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        // 오른쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
        delta += Time.deltaTime;
        //Debug.Log($"PlayerPosition : {transform.position.x}");
        Debug.Log($"델타 타임 : {delta}");
    }
}
