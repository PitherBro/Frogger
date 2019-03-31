using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject car;

	public Transform[] spawnPoints;
    public GameObject roads;
	float nextTimeToSpawn = 0f;
    private void Start()
    {
        roads = GameObject.Find("Roads");
        spawnPoints = new Transform[roads.transform.childCount*2];
        Transform road;
        int index = 0;
        for (int i=0; i < roads.transform.childCount; i++)
        {
            road = roads.transform.GetChild(i);
            spawnPoints[index] =  road.transform.GetChild(0).transform;
            index++;
           spawnPoints[index] =  road.transform.GetChild(1).transform;
            index++;
            
        }
        /*
           
        */
    }
    void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
	}

}
