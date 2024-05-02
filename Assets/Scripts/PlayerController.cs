using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal, vertical;
    public float sensitivity = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical= Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(0, horizontal, 0);
    }
}
