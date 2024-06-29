using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ControladorLuz : MonoBehaviour
{
    [SerializeField] private Light2D luz1;
    [SerializeField] private Light2D luz2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            luz1.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            luz2.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            luz1.transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
            luz2.transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            luz1.transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
            luz2.transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            luz1.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
            luz2.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }
    }
}
