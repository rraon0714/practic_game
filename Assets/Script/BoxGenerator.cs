using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Empty;

    public GameObject[] BoxPrefab;
    public int boxCount = 10;

    void Start()
    {
        GameObject Empty = Instantiate(BoxPrefab) as GameObject;
        for (int i = 0; i < boxCount; i++)
        {
            Vector2 spawnPos = GetRandomPosition();
            int randomIndex = randomIndex.Range(0, BoxPrefab.Length);
            GameObject newBox = Instantiate(BoxPrefab[randomIndex], spawnPos, Quaternion.identity);
        }

        Vector2 GetRandomPosition()
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-5f, 5f);
            return new Vector2(x, y);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    

}

