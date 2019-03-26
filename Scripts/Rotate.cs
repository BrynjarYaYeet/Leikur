using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //snýr game objectinu
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
