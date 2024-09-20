using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset distance between the player and camera

    public Animator animator;


    public float runSpeed = 40f;

    float horisontalMove = 0f;
    bool isWalking = false;

    void Update ()
    {

        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);

        horisontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("isWalking", Mathf.Abs(horisontalMove));

        if (horisontalMove > 0f)
        {
            transform.localScale = new Vector3(-3, 3, 1);
        }
        else if (horisontalMove < 0f)
        {
            transform.localScale = new Vector3(3, 3, 1);
        }
    }



















    //public float moveSpeed = 5f; // Speed at which the player moves
    //private bool isWalking = false; // To track if the player is walking

    //private Rigidbody2D rb;
    //private Animator animator;
    //private Vector2 movement;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    animator = GetComponent<Animator>();
    //}

    //void Update()
    //{
    //    // Input
    //    movement.x = Input.GetAxisRaw("Horizontal");
    //    movement.y = Input.GetAxisRaw("Vertical");

    //    // Check if the player is moving
    //    isWalking = movement != Vector2.zero;

    //    // Update animator with the isWalking condition
    //    if (animator != null)
    //    {
    //        animator.SetBool("isWalking", isWalking);
    //    }
    //}

    //void FixedUpdate()
    //{
    //    // Move the player
    //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    //}
}
