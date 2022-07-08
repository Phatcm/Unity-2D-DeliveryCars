using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float _steerSpeed = 200f;
    [SerializeField] float _moveSpeed = 12f;
    [SerializeField] float _slowSpeed = 8f;
    [SerializeField] float _boostSpeed = 16f;
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

    private void OnCollisionEnter2D(Collision2D other) {
        _moveSpeed = _slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boosters"){
            _moveSpeed = _boostSpeed;
            Debug.Log("Your speed is boosted!");
        }
    }
}
