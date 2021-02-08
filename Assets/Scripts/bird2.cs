using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird2 : MonoBehaviour
{
    [SerializeField]
    private float flyspeed = 3.5f;
    [SerializeField]
    private float flyspeedY = 5.5f;

    void Update()
    {
        if (transform.position.y < -5f)
            Destroy(gameObject);

        transform.position += new Vector3(flyspeed * Time.deltaTime, -flyspeedY * Time.deltaTime, 0);
    }

}
