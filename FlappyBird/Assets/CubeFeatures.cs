using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 12;
    public float gravityScale = 2;
    public float fallingGravityScale = 2;
    public float Score = 0;
    void Start()
    {
        gameObject.tag = "Player";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "score"){
            Score++;
            Debug.Log(Score);
            Destroy(collision.gameObject.GetComponent("EdgeCollider2D"));
        } else {
            Debug.Log("Final Score: " + Score);
            Destroy(gameObject);
        }
    }
}