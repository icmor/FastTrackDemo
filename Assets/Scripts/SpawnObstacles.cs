using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] spawns;
    public GameObject[] obstacles;
    int s;
    int o;

    void Start()
    {
        for (int i = 0; i < 4; i++){
            s = Random.Range(0, 4);
            o = Random.Range(0, 4);
            Instantiate(obstacles[o], spawns[s].transform.position, spawns[s].transform.rotation, transform);
        }

    }
}
