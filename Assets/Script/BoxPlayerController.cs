using UnityEngine;

public class BoxPlayerController : MonoBehaviour
{
     
    Rigidbody2D _rigidbody2D;
    float _jumpForce = 500.0f;
    float _walkForce = 30.0f;
    float _maxWalkSpeed = 2.0f;

    // 바닥에 접지했는지 판단
    bool isGrounded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update() {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("점프 시도");
            _rigidbody2D.linearVelocity = new Vector2(_rigidbody2D.linearVelocity.x, _jumpForce);
            isGrounded = false;
            //_rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            //isGrounded = false;
        }

        // 좌, 우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }


        // 스피드가 느릴 경우
        float speedX = Mathf.Abs(_rigidbody2D.linearVelocityX);

        // 
        if (speedX < _maxWalkSpeed)
        {
            _rigidbody2D.AddForce(transform.right * key * _walkForce);
        }
    }
        // 땅에 접지했을 경우 TRUE / FALSE에 따라 점프 가능
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
                Debug.Log("점프 시도");
            }
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
            }

        }
    }


