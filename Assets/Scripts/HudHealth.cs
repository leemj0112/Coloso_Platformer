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
        //플레이어 컴포넌트 미리 다운(캐싱)
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        //플레이어 gameObject 존재를 검사
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
