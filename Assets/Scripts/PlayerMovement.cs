using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float hm;

    private void Update()
    {
        hm = Input.GetAxis("Horizontal");
        Debug.Log(hm);
        this.transform.Translate(Time.deltaTime * moveSpeed * hm, 0, 0);
    }
}