using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite openedDoorSprite;

    BoxCollider2D boxCollider2d;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();  
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ��(Door)�� �浹�߽��ϴ�.");

            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();

            //�÷��̾� gameObject ���縦 �˻�
            if (player == null)
            {
                return;
            }

            if (player.hasKey)
            {
                //�÷��̾� ���� �P��
                player.hasKey = false;

                //���� �� ó��
                spriteRenderer.sprite = openedDoorSprite;
                boxCollider2d.enabled = false;
            }
        }
    }
}
