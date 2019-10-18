using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField]
    GameObject shotsPrefab;

    float lastSpawnTime;

    [Range(0,5)]
    public float spawnDelay = 0.2f;
    [Range(0,2)]
    public float deltaRandomSpawn = 0.5f;

    private float randomSpawnDelay;
    private bool stop = false;
    public int startLives = 3;
    public float shooterSpeed = 40f;

    public LivesController livesController; 
    public List<GameObject> shooter = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        if (shotsPrefab == null)
            return;

        randomSpawnDelay = spawnDelay;
        SpawnShot();
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.down * shooterSpeed * Time.deltaTime, Space.World);

        if (!stop && Time.time > lastSpawnTime + randomSpawnDelay)
        {
            SpawnShot();
        }
       
       
        
    }

    //metod spawnar skot mot spelaren.
    private void SpawnShot()
    {
        lastSpawnTime = Time.time;
        randomSpawnDelay = Random.Range(spawnDelay - deltaRandomSpawn, spawnDelay + deltaRandomSpawn);
        GameObject shots = Instantiate(shotsPrefab);
        shots.transform.position = transform.position;
        shooter.Add(shots);

        SpawnerController spawnerController = shots.GetComponentInChildren<SpawnerController>();
    }
    public void DestroyShooter(GameObject shots)
    {
        shooter.Remove(shots);

        //shots.SetActive(false);
    }
    public void Stop()
    {
        stop = true;

        for(int i = shooter.Count -1;i >= 0; i--)
        {
            DestroyShooter(shooter[i]);
        }
    }
}
