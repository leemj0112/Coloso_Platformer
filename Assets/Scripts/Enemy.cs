using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ���� �浹�߽��ϴ�.");

            collision.collider.SendMessage("Damage", 1);
        }
    }
}
