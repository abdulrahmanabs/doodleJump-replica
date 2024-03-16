using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] bool scoreIncreased = false;

    [SerializeField] private AudioClip jumpSound;
    private void OnCollisionEnter2D(Collision2D other)
    {

        if(!GameManager.Instance.isPlaying)return;
        if (other.relativeVelocity.y <= 0)
        {
            AudioManager.Instance.PlaySound(jumpSound);
            if (!scoreIncreased)
            {
                GameManager.Instance.ChangeScore(1);
                scoreIncreased = true;
            }
            Rigidbody2D objectRb = other.collider.GetComponent<Rigidbody2D>();
            Vector2 velocity = objectRb.velocity;
            velocity.y = jumpForce;
            objectRb.velocity = velocity;

        }
    }

}
