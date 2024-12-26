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
            Debug.Log("플레이어가 문(Door)과 충돌했습니다.");

            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();

            //플레이어 gameObject 존재를 검사
            if (player == null)
            {
                return;
            }

            if (player.hasKey)
            {
                //플레이어 열쇠 뻇기
                player.hasKey = false;

                //열린 문 처리
                spriteRenderer.sprite = openedDoorSprite;
                boxCollider2d.enabled = false;
            }
        }
    }
}
