using UnityEngine;

public class TrackMovement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Time.deltaTime * speed, 0, 0);

    }
}
