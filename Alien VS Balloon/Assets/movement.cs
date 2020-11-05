using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float movementSpeed = 15f;

    // Update is called once per frame
    void FixedUpdate()
    {
        var movement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime * movementSpeed;
    }
}