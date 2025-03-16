using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _boxPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _boxPlayer = GameObject.Find("BoxPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = _boxPlayer.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}

// 무한점프 없애기
// 움직임이나 점프 값을 바꿔보기
// 발판을 프리펩으로 만들어서 위쪽으로 자동으로 생기게하기(boxGenerator)
// 좌우로 움직이는 발판도 만들어보기(boxGenerator)