using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Empty;

    public GameObject[] BoxPrefab;
    public int boxCount = 10;

    void Start()
    {
        for (int i = 0; i < boxCount; i++)
        {
            int randomIndex = Random.Range(0, boxCount);
            Vector2 spawnPos = GetRandomPosition();
            //·£´ý ÀÎµ¦½º 
            
        }
    }
    Vector2 GetRandomPosition()
    {
        float x = Random.Range(0, 5f);
        float y = Random.Range(0, 5f);
        return new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

}

