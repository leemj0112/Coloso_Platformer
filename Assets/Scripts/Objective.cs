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
            Debug.Log("�÷��̾ ��ǥ���� �浹�߽��ϴ�.");

            SceneManager.LoadScene(nextLevelName); //����� Scene �ҷ�����
        }
    }
}
