using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed = -5;
    private int deadZone = -45;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
