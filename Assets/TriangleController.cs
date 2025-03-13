using Unity.Mathematics;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하
        transform.Translate(0, -0.01f, 0);

        // 화면 밖으로 나오면 오브젝트를 소멸
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }



        // 충돌판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;

        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
