using UnityEngine;

public class EnemyCarSpawner : MonoBehaviour
{
    public GameObject[] enemyCars;
    private int enemyCarNumber;
    private float maxSpawnPos = 3.55f;
    public float delayTimer = 1f;
    private float timer;
    private int desiredLane; //0 - left; 1 - middle; 2 - right
    private Vector3 enemyCarPos;

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
            desiredLane = Random.Range(0, 3);
            //Debug.Log("Desired line: " + desiredLane);

            switch (desiredLane)
            {
                case 0:
                    enemyCarPos = new Vector3(-maxSpawnPos, transform.position.y, transform.position.z);
                    break;
                case 1:
                    enemyCarPos = new Vector3(0, transform.position.y, transform.position.z);
                    break;
                case 2:
                    enemyCarPos = new Vector3(maxSpawnPos, transform.position.y, transform.position.z);
                    break;
            }

            //Vector3 enemyCarPos = new Vector3(Random.Range(-maxSpawnPos, maxSpawnPos), transform.position.y, transform.position.z);
            enemyCarNumber = Random.Range(0, enemyCars.Length);
            // Debug.Log(enemyCarNumber);
            Instantiate(enemyCars[enemyCarNumber], enemyCarPos, transform.rotation);
            timer = delayTimer;
        }

    }
}
