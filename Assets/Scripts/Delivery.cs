using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float _destroyDelay;
    [SerializeField] Color32 _hasPackageColor;
    [SerializeField] Color32 _noPackageColor;

    bool _hasPackage;
    SpriteRenderer _render;

    void Start() {
        _render = GetComponent<SpriteRenderer>();    
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log($"Ouch!!");
    }
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Packages" && !_hasPackage){
            Debug.Log("Package picked up");
            _hasPackage = true;
            _render.color = _hasPackageColor;
            Destroy(other.gameObject, _destroyDelay);  
        }
        else if(other.tag == "Packages" && _hasPackage){
            Debug.Log("You already carrying a package");
        }

        if(other.tag == "Customers" && _hasPackage){
            Debug.Log("Package dilivered");
            _hasPackage = false;
            _render.color = _noPackageColor;
        }
    }
}
