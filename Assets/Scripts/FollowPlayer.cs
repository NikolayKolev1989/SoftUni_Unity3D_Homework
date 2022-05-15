using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    //public float camRotationSpeed = 50f;

    // Update is called once per frame

    /*
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
    */

    private void FixedUpdate()
    {
        //Vector3 desiredPosition = plane.transform.position + offset;
        //Vector3 smoothDesiredPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        var desiredPosition = plane.transform.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);       

        transform.LookAt(plane.transform);
    }
}
