using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectTilepickUp : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 발사체(ProjectTile PickUp)와 충돌했습니다.");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            // 발사체 획득 처리
            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();
            player.hasprojecttile = true;

            //발사체 소멸 처리
            GameObject.Destroy(gameObject);
        }
    }
}
