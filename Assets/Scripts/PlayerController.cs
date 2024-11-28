using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 15f;
    public bool isGrounded;
    public float xDerection;


    Rigidbody2D PlayerRB;
    Animator animator;

    void Start()
    {
        Debug.Log("Start()가 출력되었습니다.");
        PlayerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //플레이어 캐릭터 방향 처리
        xDerection = Input.GetAxis("Horizontal");
        if (Mathf.Abs(xDerection) > 0)
        {
            if (xDerection < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        isGrounded = Physics2D.CircleCast(transform.position, 0.3f, Vector2.down, 1.1f, LayerMask.GetMask("Platforms"));     //(던지는 객체, 힘, 방향, 거리)
        animator.SetBool("Grounded", isGrounded);       //Grounded의 값을 isGrounded로 바꿔라

        //조건 1. 플레이어가 땅("Platforms')에 발을 딛고 있는가?
        //조건 2. isGrounded가 true인가?
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //스페이스 바를 눌렀을 때 점프 처리
            Debug.Log("플레이어가 점프합니다.");
            PlayerRB.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);     //Vecter2 (0, 1)
        }
        
    }

     void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1.1f);      //(선 시작, 선 끝)
    }

    void FixedUpdate()
    {
        PlayerRB.velocity = new Vector2(xDerection * moveSpeed, PlayerRB.velocity.y);
    }
}
