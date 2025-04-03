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

    //private float _xMovieSpeed;
    //private float _xDelta = 2;
    //private float _xStarPosition;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        beforeY = -3;
        currentPosition = transform.position.x;
    }

    void Update()
    {

        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject newBox = Instantiate(BoxPrefab);
            //GameObject gameObject = Instantiate(BoxPrefab) as GameObject;

            //·£´ýÀ¸·Î x,y °´Ã¼ »ý¼º
            float positionX = Random.Range(boforeX - 4.0f, boforeX + 4.0f);
            float positionY = Random.Range(1.8f, 2.3f);
            beforeY += positionY;
            boforeX = positionX;
            newBox.transform.position = new Vector3(positionX, beforeY, 0);


            //gameObject.transform.position = new Vector3(positionX, beforeY, 0);
            //gameObject.transform.Translate(new Vector3(3, 0, 0));

            Rigidbody2D rb = newBox.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(speed * direction, 0);
            }


            //currentPosition += Time.deltaTime * direction;
            //if (currentPosition >= rightMax)
            //{
            //    direction *= -1;
            //    currentPosition = rightMax;
            //}
            //else if (currentPosition <= leftMax)
            //{
            //    direction *= -1;
            //    currentPosition = leftMax;
            //}

            //transform.position = new Vector3(currentPosition, 0, 0);
            //transform.Translate(distanceMax * Time.deltaTime * Mathf.Sin(refNum + Time.time * speed), 0, 0);

            //float x = _xStarPosition + _xDelta * Mathf.Sin(Time.time * _xMovieSpeed);
            //transform.position = new Vector3(x, transform.position.y, 0);
        }
    }
}
