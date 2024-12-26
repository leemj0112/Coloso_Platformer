using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int health = 5;

    public float moveSpeed = 5f;
    public float jumpforce = 15f;
    public bool isGrounded;
    public bool hasKey;
    public float xDerection;


    Rigidbody2D PlayerRB;
    Animator animator;

    void Start()
    {
        Debug.Log("Start()�� ��µǾ����ϴ�.");
        PlayerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void Damage(int damage)
    {
        Debug.Log($"{damage}�� �޾Ҵ�.");

        health -= 1;
        if (health < 0 ) 
        {
            health = 0;
        }
        if(health == 0) //ü���� 0�̸�
        {
            //���ӿ��� �̺�Ʈ
            GameManager.instanse.GameOver();
        }

        animator.SetTrigger("Hurt");
    }

    void Update()
    {
        //�÷��̾� ĳ���� ���� ó��
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

        isGrounded = Physics2D.CircleCast(transform.position, 0.3f, Vector2.down, 1.1f, LayerMask.GetMask("Platforms"));     //(������ ��ü, ��, ����, �Ÿ�)
        animator.SetBool("Grounded", isGrounded);       //Grounded�� ���� isGrounded�� �ٲ��

        //���� 1. �÷��̾ ��("Platforms')�� ���� ��� �ִ°�?
        //���� 2. isGrounded�� true�ΰ�?
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //�����̽� �ٸ� ������ �� ���� ó��
            Debug.Log("�÷��̾ �����մϴ�.");
            PlayerRB.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);     //Vecter2 (0, 1)
        }
        
    }

     void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1.1f);      //(�� ����, �� ��)
    }

    void FixedUpdate()
    {
        PlayerRB.velocity = new Vector2(xDerection * moveSpeed, PlayerRB.velocity.y);
    }
}
