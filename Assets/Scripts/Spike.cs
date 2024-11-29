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

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //빌드된 Scene 불러오기
        }
    }
}
