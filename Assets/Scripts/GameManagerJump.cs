using System.Collections;
using UnityEngine;

public class GameManagerJump : MonoBehaviour
{
    private static bool platformsGenerated = false;

    void Start()
    {
        if (!platformsGenerated)
        {
            GeneratePlatforms();
            platformsGenerated = true;
        }
    }

    void GeneratePlatforms()
    {
        GameObject platformPrefab = Resources.Load<GameObject>("PlatformPrefab"); // Substitua pelo caminho correto
        if (platformPrefab == null)
        {
            Debug.LogError("PlatformPrefab not found. Please assign the correct prefab.");
            return;
        }

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < 300; i++) // Altere conforme necessário
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
