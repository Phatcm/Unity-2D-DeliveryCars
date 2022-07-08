using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheCar : MonoBehaviour
{
    [SerializeField] GameObject FollowThings;

    // Update is called once per frame
    private void LateUpdate() {
        transform.position = FollowThings.transform.position + new Vector3(0,0,-10);
    }
}
