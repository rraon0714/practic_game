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
        // �����Ӹ��� ������� ����
        transform.Translate(0, -0.01f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ�
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }



        // �浹����
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
