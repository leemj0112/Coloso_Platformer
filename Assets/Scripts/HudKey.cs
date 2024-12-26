using UnityEngine;
using UnityEngine.UI;

public class HudKey : MonoBehaviour
{
    public Sprite hasKeySprite;
    public Sprite hasNoKeySprite;

    Image Image;

    PlayerController player;
    void Start()
    {
        //플레이어 컴포넌트 미리 다운(캐싱)
        player = FindObjectOfType<PlayerController>();
        
        //이미지 컴포넌트 미리 저장
        Image = GetComponent<Image>();

        //열쇠 gameobject의 존재를 검사
        GameObject key = GameObject.FindGameObjectWithTag("Key");
        if (key == null)
        {
            gameObject.SetActive(false);
        }
    }


    void Update()
    {
        //플레이어 gameObject 존재를 검사
        if(player == null) 
        {
            return;
        }
        
        //hasKey가 ture라면 sprite를 변경 (열쇠 있음)
        if (player.hasKey)
        {
            Image.sprite = hasKeySprite;
        }
        //hasKey가 false라면 sprite를 변경 (열쇠 없음)
        else
        {
            Image.sprite = hasNoKeySprite;
        }
    }
}
