using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPositions;

    void Start()
    {
        int amount = PlayerPrefs.GetInt("EnemyAmount", 1);
        for(int i = 0; i < amount; i++) {
            Instantiate(enemyPrefab, spawnPositions[i].position, spawnPositions[i].rotation);
        }
    }
}
