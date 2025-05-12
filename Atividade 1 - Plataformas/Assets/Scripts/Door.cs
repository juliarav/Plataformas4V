using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private string doorID;

    private void OnEnable()
    {
        EventChannel.OnDoorOpen += HandleDoorOpen;
    }

    private void OnDisable()
    {
        EventChannel.OnDoorOpen -= HandleDoorOpen;
    }

    private void HandleDoorOpen(string triggeredDoorID)
    {
        if (triggeredDoorID == doorID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        gameObject.SetActive(false);
    }

}
