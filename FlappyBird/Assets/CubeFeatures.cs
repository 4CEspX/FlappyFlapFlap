using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 6;
    public float gravityScale = 2;
    public float fallingGravityScale = 1;
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
        if (gameObject.transform.position.x > -3.65f || gameObject.transform.position.x < -3.75f) {
            transform.position = new Vector3(-3.7f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "score"){
            Destroy(collision.gameObject.GetComponent("EdgeCollider2D"));
            Score++;
            Debug.Log(Score);
        } else {
            Debug.Log("Final Score: " + Score);
            Destroy(gameObject);
        }
    }
}