using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpforce = 15f;
    public float xDerection;
    Rigidbody2D PlayerRB;

    void Start()
    {
        Debug.Log("Start()�� ��µǾ����ϴ�.");
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�÷��̾ �����մϴ�.");
            PlayerRB.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);     //Vecter2 (0, 1)
        }
    }

    void FixedUpdate()
    {
        PlayerRB.velocity = new Vector2(xDerection * moveSpeed, PlayerRB.velocity.y);
    }
}
