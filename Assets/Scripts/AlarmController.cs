using UnityEngine;

public class AlarmController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        AlarmSensor.AlarmOn += AlarmStart; 
        AlarmSensor.AlarmOff += AlarmStop;
    }

    private void OnDisable()
    {
        AlarmSensor.AlarmOn -= AlarmStart;
        AlarmSensor.AlarmOff -= AlarmStop;
    }

    private void AlarmStart()
    {
        _audioSource.Play();
    }

    private void AlarmStop() 
    {
        _audioSource.Stop();
    }
}
