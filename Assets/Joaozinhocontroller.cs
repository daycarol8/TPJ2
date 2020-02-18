using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joaozinhocontroller : MonoBehaviour
{
    [SerializeField] CharacterController bla;
    public float speed = 3.0F;
    public float rotateSpeed = 5.0F;


    void Update()
    {
        
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        transform.Rotate(Input.GetAxis("Mouse Y") * rotateSpeed, 0, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        bla.SimpleMove(forward * curSpeed);
    }
}
