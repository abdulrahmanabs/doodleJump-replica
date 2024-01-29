
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float horizontalMovement;
    Rigidbody2D rb;
    

    #region Unity Methods
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isPlaying)
            return;

        GetInput();
    }


    private void FixedUpdate()
    {
        Move();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.y >= 0 && other.gameObject.CompareTag("Lose"))
        {
            GameManager.Instance.Lose();
        }
        else if (other.gameObject.CompareTag("Win"))
        {
            print("WIN");
            GameManager.Instance.Win();
            horizontalMovement=0;

        }
    }

    #endregion

    #region Movement Methods

    private void Move()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = horizontalMovement * moveSpeed;
        rb.velocity = velocity;
    }

    private void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
    }
    #endregion
}
