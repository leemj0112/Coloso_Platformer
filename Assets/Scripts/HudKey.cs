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
        //�÷��̾� ������Ʈ �̸� �ٿ�(ĳ��)
        player = FindObjectOfType<PlayerController>();
        
        //�̹��� ������Ʈ �̸� ����
        Image = GetComponent<Image>();

        //���� gameobject�� ���縦 �˻�
        GameObject key = GameObject.FindGameObjectWithTag("Key");
        if (key == null)
        {
            gameObject.SetActive(false);
        }
    }


    void Update()
    {
        //�÷��̾� gameObject ���縦 �˻�
        if(player == null) 
        {
            return;
        }
        
        //hasKey�� ture��� sprite�� ���� (���� ����)
        if (player.hasKey)
        {
            Image.sprite = hasKeySprite;
        }
        //hasKey�� false��� sprite�� ���� (���� ����)
        else
        {
            Image.sprite = hasNoKeySprite;
        }
    }
}
