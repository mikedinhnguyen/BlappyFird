using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0;
    [SerializeField] int spawnTime = 2;
    [SerializeField] int heightOffset = 7;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestPoint, highestPoint), 0) , transform.rotation);
    }
}
