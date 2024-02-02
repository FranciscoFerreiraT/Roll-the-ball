using UnityEngine;

public class CamaraPrimeraPersona : MonoBehaviour
{
    public float speed = 5f; 
    public float mouseSensitivity = 2f; 

    private CharacterController characterController;

    float verticalRotation = 0f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        // Movimiento
        float forwardBackward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float leftRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 moveDirection = transform.TransformDirection(Vector3.forward) * forwardBackward + transform.TransformDirection(Vector3.right) * leftRight;
        characterController.Move(moveDirection);

        // Rotación
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); 

        transform.Rotate(Vector3.up * mouseX);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}
