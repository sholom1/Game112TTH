using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 5;
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F2");
        if (timer <= 0)
        {
            audioSource.PlayOneShot(audioClip);
            timer = 5;
        }
    }
}
