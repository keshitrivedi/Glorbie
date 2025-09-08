using UnityEngine;

public class Player : MonoBehaviour
{
    // private float xPos = 0;
    // private float yPos = 0;
    // private float zPos = 0;
    // private float speed = 5f;

    // private float horizontal;
    // private float vertical;
    // private float speed = 5f;

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     zPos += speed * Time.deltaTime;
        // }

        // if (Input.GetKey(KeyCode.S))
        // {
        //     zPos -= speed * Time.deltaTime;
        // }

        // if (Input.GetKey(KeyCode.D))
        // {
        //     gameObject.transform.rotation *= Quaternion.Euler(0, 1, 0);
        // }

        // if (Input.GetKey(KeyCode.A))
        // {
        //     gameObject.transform.rotation *= Quaternion.Euler(0, -1, 0);
        // }

        // gameObject.transform.position = new Vector3(xPos, yPos, zPos);

        // horizontal = Input.GetAxis("Horizontal");
        // vertical = Input.GetAxis("Vertical");

        // transform.position = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
