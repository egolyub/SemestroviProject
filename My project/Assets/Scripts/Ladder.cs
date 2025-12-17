using UnityEngine;

public class Stay2D : MonoBehaviour
{
    [SerializeField] float speed = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().gravityScale = 0; //отключили гравитацию
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Collider");
            if (Input.GetKey(KeyCode.W))
            {

                other.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, speed);

            }
            else if (Input.GetKey(KeyCode.S))
            {
                other.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -speed);

            }
            else
            {
                other.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().gravityScale = 1; //включили гравитацию
    }

}