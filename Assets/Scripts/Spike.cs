using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 가시에 충돌했습니다.");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            //게임오버 이벤트
            GameManager.instanse.GameOver();
        }
    }
}
