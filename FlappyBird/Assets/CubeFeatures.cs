using Unity.VisualScripting;
using UnityEngine;
public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 12;
    public float gravityScale = 2;
    public float fallingGravityScale = 2;
    public float Score = 0;
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
        Destroy(gameObject);
    }
}