using UnityEngine;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private float _deltaVolume = 0.3f;
    private float _maxVolume = 1.0f;
    private float _incrementVolume;

    private void OnEnable()
    {
        SecurityAlarm.DangerOn += AlarmStart;
        SecurityAlarm.DangerOff += AlarmStop;
    }

    private void OnDisable()
    {
        SecurityAlarm.DangerOn -= AlarmStart;
        SecurityAlarm.DangerOff -= AlarmStop;
    }

    private void AlarmStart()
    {
        _incrementVolume = _deltaVolume;
        _audioSource.Play();
    }

    private void AlarmStop()
    {
        _incrementVolume = -_deltaVolume;
    }

    private void Update()
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _incrementVolume * Time.deltaTime);
    }

}
