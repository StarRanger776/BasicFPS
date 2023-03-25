using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _mouseMovement = 200; //[SerializedField] attribute used to show private variable in the inspector-- controls how fast we want to rotate

    private Transform parent; //reference to our parent object
    private Camera _fpsCamera;
    float cameraClamp = 0f;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        _fpsCamera = Camera.main; //Accessing our object camera
        parent = transform.parent; //the parent of our object is the object we want to rotate
    }

    private void Update()
    {
        float horizontalRotation = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime; //horizontal rotation calculation
        //float verticalRotation = Input.GetAxis("Mouse Y") * _mouseMovement * Time.deltaTime; //horizontal rotation calculation

        parent.Rotate(0, horizontalRotation, 0); //rotate parent around the vertical axis-- horizontal movement
        //parent.Rotate(-verticalRotation, 0, 0); //rotate parent around the vertical axis-- horizontal movement

    }
}
