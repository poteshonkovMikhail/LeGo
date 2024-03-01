using UnityEngine;
public class MouseLook : MonoBehaviour
{

    public float horizontalSpeed = 1f;

    public float verticalSpeed = 1f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera _camera;

    void Start()
    {
        _camera = Camera.main;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        _camera.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
