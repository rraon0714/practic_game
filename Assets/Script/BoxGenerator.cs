using UnityEngine;

public class BoxGeneratorScript : MonoBehaviour
{
    public GameObject BoxPrefab;
    float delta = 0;
    float span = 1.0f;
    float beforeY = 0.0f;
    float boforeX = 0.0f;
    float speed = 2.0f;
    private Rigidbody2D rb;
    float direction = 3.0f;

    float currentPosition;
    float rightMax = 2.0f;
    float leftMax = -2.0f;
    float distanceMax = 1f;
    public float refNum = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        beforeY = -3;
        currentPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject gameObject = Instantiate(BoxPrefab) as GameObject;
            float positionX = Random.Range(boforeX - 4.0f, boforeX + 4.0f);
            float positionY = Random.Range(2.0f, 2.8f);
            beforeY += positionY;
            boforeX = positionX;
            gameObject.transform.position = new Vector3(positionX, beforeY, 0);

            gameObject.transform.Translate(new Vector3(3, 0, 0));
            //transform.position = Vector3.MoveTowards(gameObject.transform.position, rb.transform.position, 0.1f);
            currentPosition += Time.deltaTime * direction;
            if (currentPosition >= rightMax)
            {
                direction *= -1;
                currentPosition = rightMax;
            }
            else if (currentPosition <= leftMax)
            {
                direction *= -1;
                currentPosition = leftMax;
            }
            transform.position = new Vector3(currentPosition, 0, 0);
            transform.Translate(distanceMax * Time.deltaTime * Mathf.Sin(refNum + Time.time * speed), 0, 0);
        }
    }
}
