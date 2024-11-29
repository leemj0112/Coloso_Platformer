using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    public string nextLevelName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 목표물에 충돌했습니다.");

            SceneManager.LoadScene(nextLevelName); //빌드된 Scene 불러오기
        }
    }
}
