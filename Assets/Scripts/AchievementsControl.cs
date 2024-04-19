using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsControl : MonoBehaviour
{
    public static AchievementsControl instance;
    public bool[] achievements = { false, false, false, false, false };
    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void SetAchiement(AchievItem item, bool state)
    {
        achievements[item.id] = state;
        HUDController.instance?.UpdateHUD();

    }
}
