using UnityEngine;

public class birdgo : MonoBehaviour
{
    [SerializeField]
    private float flyspeed = 4.5f;
    [SerializeField]
    private float flyspeedY = 1f;

    void Update()
    {
        if (transform.position.x < -3f)
            Destroy(gameObject);

        transform.position -= new Vector3(flyspeed * Time.deltaTime, 0, 0);
    }
}
