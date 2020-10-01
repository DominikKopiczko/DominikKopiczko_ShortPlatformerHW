using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject PlayerObject;
    public float speed = 2;
    
    void Update () {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, PlayerObject.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, PlayerObject.transform.position.x, interpolation);

        this.transform.position = position;
    }
}