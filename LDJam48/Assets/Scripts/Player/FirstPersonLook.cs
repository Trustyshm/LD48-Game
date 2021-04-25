using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{

    public float lookSensitivity = 100f;
    public Transform playerTransform;
    public bool isActive;

    [Header("Y Clamping")]
    public float minimumY;
    public float maximumY;


    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Hide Cursor
        isActive = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float Xmouse = Input.GetAxis("Mouse X") * lookSensitivity * Time.deltaTime;
        float Ymouse = Input.GetAxis("Mouse Y") * lookSensitivity * Time.deltaTime;

        xRotation -= Ymouse;
        xRotation = Mathf.Clamp(xRotation, -minimumY, maximumY);

        if (isActive)
        {
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); ;
            playerTransform.Rotate(Vector3.up * Xmouse);
        }
        


    }
}
