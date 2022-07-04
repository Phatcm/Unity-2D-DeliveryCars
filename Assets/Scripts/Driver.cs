using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float _steerSpeed;
    [SerializeField] float _moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _steerAmount = Input.GetAxis("Horizontal") *_steerSpeed *Time.deltaTime;
        float _moveAmount = Input.GetAxis("Vertical") * _moveSpeed *Time.deltaTime;
        transform.Rotate(0,0, -_steerAmount);
        transform.Translate(0, _moveAmount, 0);
    }
}
