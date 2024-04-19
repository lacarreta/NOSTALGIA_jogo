using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{

    public GameObject[] achievementImage;
    public static HUDController instance;

    void Start()
    {
        instance = this;
        UpdateHUD();
    }

    // Update is called once per frame
    public void UpdateHUD()
    {
        for (int i = 0; i < AchievementsControl.instance.achievements.Length; i++)
        {
            achievementImage[i].SetActive(AchievementsControl.instance.achievements[i]);
        }
    }
}
