using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Coletavel"))
        {
            Destroy(collision.gameObject);
            GameController.Collect();
            if (audioSource != null) audioSource.Play();
        }

        if (collision.CompareTag("Enemy"))
        {
            GameController.TakeDamage();
        }
    }
}