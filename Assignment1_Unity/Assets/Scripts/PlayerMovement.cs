using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // initialization if needed
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
