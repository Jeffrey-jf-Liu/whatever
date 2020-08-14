using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove_Easy : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    Vector2 MovementDirection;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        MovementDirection = Vector2.right;
    }
    // Update is called once per frame
    void Update()
    {
        Move(MovementDirection);
    }
    public void Move(Vector2 direction)
    {
        MovementDirection = direction;
        body.velocity = new Vector2(direction.x * speed,body.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.tag == ("Enemy"))
        {
            MovementDirection *= -1f;
        }
    }
    public void LoadFirstScene()
    {
        int CurrentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentLevel);
    }
}