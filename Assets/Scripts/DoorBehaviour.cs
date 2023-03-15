using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    float currAngle = 0;
    float desiredAngle = 0;

    // Update is called once per frame
    void Update()
    {
        currAngle = Mathf.LerpAngle(currAngle, desiredAngle, Time.deltaTime * 3f);
        transform.localEulerAngles = new Vector3(currAngle, 0, 0);
    }

    void OpenDoors()
    {
        desiredAngle = 75f;
    }

    void CloseDoors()
    {
        desiredAngle = 0;
    }
}
