using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] itemsToSpawn;

    public float spawnDistance = 3f; //Максимально возможное расстояние между платформами
    public float lastSpawnY; //Позиция последнего спавна



	// Use this for initialization
	void Start () {
        lastSpawnY = transform.position.y; //Инициализируем используя текущую позицию спавна
	}
	
	
	void Update () {
	if (transform.position.y - lastSpawnY >= spawnDistance)
        // если с момента последнего спавна прошло больше максимального то пора спавнить

        {
            Spawn();
            lastSpawnY = transform.position.y; // запоминаем позицию позицию спавна
        }
	}

    void Spawn()
    {
        int count = Random.Range(1, 3);

        for (int i = 0; i< count;i++)
        {
            //определим позицию (по иксу от -2 до 3, при чем важно, что числа флоат по-другому будет генеритьсчя целые числа
            Vector3 pos = new Vector3(Random.Range(-2f, 3f), this.transform.position.y);
            GameObject item = itemsToSpawn[Random.Range(0, itemsToSpawn.Length)];
            Instantiate(item, pos, Quaternion.identity);
        }
    }

}
