using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    [SerializeField] private GameObject Player; //An object camera will follow
    [SerializeField] private Vector3 offset; // Camera's distance from the object

    private void LateUpdate() //Works after all update functions called
    {
        Vector3 positionToGo = Player.transform.position + offset; //Target position of the camera
        Vector3 smoothPosition = Vector3.Lerp(a: transform.position, b: positionToGo, t: 0.8F * Time.deltaTime);
        transform.position = smoothPosition;
        //transform.LookAt(_object.transform.position); //Camera will look(returns) to the object
    }
}

