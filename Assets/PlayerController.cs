using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float delta = 0;

    // ȭ�鿡 ���� ��, ó�� ����Ǵ� �Լ�
    // �ѹ��� ����˴ϴ�.
    void Start()
    {
        
    }

    // Update is called once per frame
    // �� ������ ����Ǵ� �Լ�
    void Update()
    {
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        // ������ ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
        delta += Time.deltaTime;
        //Debug.Log($"PlayerPosition : {transform.position.x}");
        Debug.Log($"��Ÿ Ÿ�� : {delta}");
    }
}
