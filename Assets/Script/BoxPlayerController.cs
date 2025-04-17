using UnityEngine;
public class BoxPlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    float _jumpForce = 500.0f;
    float _walkForce = 30.0f;
    float _maxWalkSpeed = 2.0f;
    var dir = Vector2.Zero;
    bool moving = false;


    bool _isGrounded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       



        // Jump
        //if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        //{
        //    _rigidbody2D.AddForce(transform.up * _jumpForce);
        //    _isGrounded = true;
        //}

        //Debug.Log(_rigidbody2D.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("점프");
            _rigidbody2D.AddForce(transform.up * _jumpForce);
            _isGrounded = true;
        }


        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }


        // 플레이어의 속도
        float speedX = Mathf.Abs(_rigidbody2D.linearVelocityX);

        if (speedX < _maxWalkSpeed)
        {
            _rigidbody2D.AddForce(transform.right * key * _walkForce);
        }

        if (key != 0)
        {
            if (key == 1)
            {

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter2D");
        _isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit2D");
        _isGrounded = false;
    }

    public void SetDestPosition(Vector2 _destPostion)
    {
        var destPostion;
        dir = destPosition - currentPosition;
        dir = dir.normalized;
        moving = true;
    }

}


// 숙제
// 발판 생성이 조금 더 디테일하게 될 수 있도록 스크립트 수정
// 움직이는 발판 만들어보기
// 화면 밖으로 나간 발판 삭제하기
// 발판을 일정 갯수 이상 만들고 마지막 발판 위에 오브젝트를 생성해서 거기까지 도착하면 게임이 끝나게 변경
// 특정 높이 이상 올라가서 특정이하로 떨어지면 게임 오버
// 만들고 싶은 게임에 대한 문서 (개요, 필요 기능등..)