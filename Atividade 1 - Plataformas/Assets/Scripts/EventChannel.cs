using System;
using UnityEngine;

public static class EventChannel
{
    public static event Action<string> OnDoorOpen;

    public static void RaiseDoorOpen(string doorID)
    {
        OnDoorOpen?.Invoke(doorID);
    }

}
