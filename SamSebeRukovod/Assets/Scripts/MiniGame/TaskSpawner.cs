using UnityEngine;

public class TaskSpawner : MonoBehaviour {
    public GameObject[] taskPrefabs;
    public float spawnInterval = 1f;
    private float timer;

    public float spawnXRange = 8f;
    public float spawnY = 6f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnTask();
            timer = 0f;
        }
    }

    private void SpawnTask()
    {
        int index = Random.Range(0, taskPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange, spawnXRange), spawnY, 0);
        Instantiate(taskPrefabs[index], spawnPos, Quaternion.identity);
    }
}
