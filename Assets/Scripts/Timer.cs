using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 5;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public UnityEvent OnTimerElapse;

    private bool isElapsed = false;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F2");
        if (timer <= 0 && !isElapsed)
        {
            isElapsed = true;
            OnTimerElapse.Invoke();
        }
    }
}
