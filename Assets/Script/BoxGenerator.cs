using UnityEngine;

public class BoxGeneratorScript : MonoBehaviour
{
    public GameObject BoxPrefab;
    float delta = 0;
    float span = 1.0f;
    float beforeY = 0.0f;
    float boforeX = 0.0f;

    float speed = 0.5f;
    private Rigidbody2D rb;
    private float direction = 3.0f;
    public float range = 2.0f;

    private float starX;

    float currentPosition;
    float rightMax = 2.0f;
    float leftMax = -2.0f;
    float distanceMax = 1.0f;
    public float refNum = 0f;

    // �����Ǵ� ��ü �� ����
    int countHuddle = 10;
    int countCurrentObject = 0;

    //public float DestructionDelay = 4.0f;
    private Vector2 limitMin = new Vector2(-5.0f, -4.0f);
    private Vector2 limitMax = new Vector2(5.0f, 4.0f);



    void Start()
    {
        starX = transform.position.x;
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()

    {
        // ���� ������ ������ ��ü �̻��� �ʰ����� ��� ����
        if(countCurrentObject + 1 > countHuddle)
        {
            return;
        }


        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        if(Mathf.Abs(transform.position.x - starX) > range)
        {
            direction *= -1;
        }

        // ��ü �������� ����
        // update()�� ���� �Լ��� ȣ���� ������  ���� �����Ͽ� ����
        delta += Time.deltaTime;
        for(int i = 0; i < countHuddle; i++) { 
        if (delta > span)
        {
            delta = 0;

            // ��ġ ���� 
            float positionX = Random.Range(boforeX - 4.0f, boforeX + 4.0f);
            float positionY = Random.Range(1.8f, 2.3f);
            beforeY += positionY;
            boforeX = positionX;

            // beforey, boforex ��ġ ���� ���� ��ü ���� 
            GameObject newBox = Instantiate(BoxPrefab);
            newBox.transform.position = new Vector3(positionX, beforeY, 0);

            // ���� ��, �� ������
            transform.Translate(distanceMax * Time.deltaTime * Mathf.Sin(refNum + Time.time * speed),0,0); 

            Rigidbody2D rb = newBox.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = new Vector2(speed * direction, 0);
            }
            countCurrentObject++;

            // ������ ����� ��� ����
            if(transform.position.x < limitMin.x || transform.position.x > limitMax.x || 
               transform.position.y < limitMin.y || transform.position.y > limitMax.y)
            {
                Destroy(newBox);
            }
        }   
        }
    }
}          