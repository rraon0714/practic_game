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

// �������� ���ֱ�
// �������̳� ���� ���� �ٲ㺸��
// ������ ���������� ���� �������� �ڵ����� ������ϱ�(boxGenerator)
// �¿�� �����̴� ���ǵ� ������(boxGenerator)