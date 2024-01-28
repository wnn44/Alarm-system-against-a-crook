using System;
using UnityEngine;

public class SecurityAlarm : MonoBehaviour
{
    [SerializeField] private GameObject _thief;

    public static event Action DangerOn;
    public static event Action DangerOff;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _thief)
        {
            DangerOn?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == _thief)
        {
            DangerOff?.Invoke();
        }
    }
}
