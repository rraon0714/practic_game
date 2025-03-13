using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject BoxPrefab;
    public int [] BoxCount;



    void Start()
    {
        BoxCount = new int[10];
        
        //for (int i = 0; i < BoxCount.Length; i++)
        //{
        //    Vector2 spawnPos = GetRandomPosition();
        //    Instantiate(BoxPrefab, new Vector3(spawnPos.x, spawnPos.y, 0), Quaternion.identity);
        //}

        // GetRandomPosition 함수 추가
        //Vector2 GetRandomPosition()
        //{
        //    float x = Random.Range(-5f, 5f);
        //    float y = Random.Range(-5f, 5f);
        //    return new Vector2(x, y);
        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
    

    }

