using System;
using UnityEngine;

public class AlarmSensor : MonoBehaviour
{
    [SerializeField] private GameObject _thief;

    public static event Action AlarmOn;
    public static event Action AlarmOff;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AlarmOn?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        AlarmOff?.Invoke();
    }
}
