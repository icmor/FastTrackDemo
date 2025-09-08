using UnityEngine;

public class DestroyTrack : MonoBehaviour
{
    public GameObject track;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Destroy(track, 1.0f);
        }
    }
}
