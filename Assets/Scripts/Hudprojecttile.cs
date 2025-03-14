using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hudprojecttile : MonoBehaviour
{
    PlayerController player;
    Image Image;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        Image = GetComponent<Image>();
    }

    void Update()
    {
        if(player == null)
        {
            return;
        }

        if (player.hasprojecttile)
        {
            Image.enabled = true;
        }
        else
        {
            Image.enabled = false;
        }
    }
}
