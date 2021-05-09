using UnityEngine;

public class EnemyCarSpawner : MonoBehaviour
{
    public GameObject[] enemyCars;
    private int enemyCarNumber;
    public float maxSpawnPos = 1.5f;
    public float delayTimer = 1f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Vector3 enemyCarPos = new Vector3(Random.Range(-maxSpawnPos, maxSpawnPos), transform.position.y, transform.position.z);
            enemyCarNumber = Random.Range(0, enemyCars.Length-1);
            // Debug.Log(enemyCarNumber);
            Instantiate(enemyCars[enemyCarNumber], enemyCarPos, transform.rotation);
            timer = delayTimer;
        }

    }
}
