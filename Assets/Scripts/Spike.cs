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
            Debug.Log("�÷��̾ ���ÿ� �浹�߽��ϴ�.");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //����� Scene �ҷ�����
        }
    }
}
