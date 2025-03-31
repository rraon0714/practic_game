using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject _boxPlayer;

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

        //if(transform.position.y < -6.0)
        //{
        //    Destroy(_boxPlayer);
        //}
    }
}

