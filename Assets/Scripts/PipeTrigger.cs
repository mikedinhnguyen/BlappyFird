using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    private LogicScript logic;
    private BirdMovement bird;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.IsTouchingLayers(3) && bird.isAlive)
        {
            logic.AddScore(1);
            logic.PlaySound();
        }
    }
}
