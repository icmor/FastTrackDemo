using UnityEngine;

public class SpawnTrack : MonoBehaviour
{
    public GameObject track;
    public Transform spawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Instantiate(track, spawn.position, spawn.rotation);
        }
    }
}
