using UnityEngine;

public class Doorctrl : MonoBehaviour
{
    public GameObject door;

    public void OpenDoor()
    {
        Vector3 rotationToAdd = new Vector3(75, 0, 0);
        door.transform.Rotate(rotationToAdd);
    }

    public void CloseDoor()
    {
        Vector3 rotationToAdd = new Vector3(-75, 0, 0);
        door.transform.Rotate(rotationToAdd);
        Debug.Log("Closed");
    }
}
