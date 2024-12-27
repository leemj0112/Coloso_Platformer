using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudHealth : MonoBehaviour
{
    public List<Image> hearts = new List<Image>();
    public Sprite hasHeartSprite;
    public Sprite hasNoHeartSprite;

    PlayerController player;

    void Start()

    {
        //�÷��̾� ������Ʈ �̸� �ٿ�(ĳ��)
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        //�÷��̾� gameObject ���縦 �˻�
        if (player == null)
        {
            return;
        }

        for(int i = 0; i < hearts.Count; i++)
        {
            if(i < player.health)
            {
                hearts[i].sprite = hasHeartSprite;
            }
            else
            {
                hearts[i].sprite = hasNoHeartSprite;
            }
        }
    }
}
