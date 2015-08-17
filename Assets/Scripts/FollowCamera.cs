using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

    public GameObject target;
    Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {
        // Orient the camera behind the target, we first need to get the angle of the target 
        // and turn it into a rotation in the LateUpdate() method:
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        // Multiply the offset by the rotation to orient the offset the same as the target. 
        // Then subtract the result from the position of the target.
        transform.position = target.transform.position - (rotation * offset);

        // Keep looking at the player:
        transform.LookAt(target.transform);
    }
}
