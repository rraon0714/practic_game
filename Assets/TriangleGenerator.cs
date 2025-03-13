using UnityEngine;

public class TriangleGeneratorScript : MonoBehaviour
{
    public GameObject TrianglePrefab;
    float delta = 0;
    float span = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject gameObject = Instantiate(TrianglePrefab) as GameObject;
            int positionX = Random.Range(-6, 7);
            gameObject.transform.position = new Vector3(positionX, 10, 0);
        }
    }
}
