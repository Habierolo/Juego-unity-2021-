using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    [Range(0, 10)]

    [Tooltip("velocidad del movimiento del personaje")]
    public float speed;
    public float RotationSpeed;
    void Update()
    {
        float space = speed * Time.deltaTime;

        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        transform.Translate(dir.normalized * space);


        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * RotationSpeed, 0);

        
    }
}
