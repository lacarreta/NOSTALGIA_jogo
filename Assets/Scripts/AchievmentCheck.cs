
using UnityEngine;

public class AchievmentCheck : MonoBehaviour
{
    public int achievementID;
    public bool ativar;
    void Start()
    {
        if (AchievementsControl.instance.achievements[achievementID] == ativar)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

}
