using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Rigidbody2D bird;
    public int jumpSpeed = 10;
    public bool isAlive = true;
    private LogicScript logic;
    private int deadZone = 14;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            bird.velocity = Vector2.up * jumpSpeed;
        }
        if (bird.position.y > deadZone || bird.position.y < -deadZone)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" && isAlive)
        {
            bird.AddForce(Vector2.left * 5, ForceMode2D.Impulse);
            logic.PlayFailSound();
            GameOver();
        }
        
    }

    void GameOver()
    {
        logic.SaveScore();
        isAlive = false;
        gameOverScreen.SetActive(true);
    }
}
