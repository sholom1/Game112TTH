using UnityEngine;
using UnityEngine.Events;

public class OneShotTimer : MonoBehaviour
{
    public float timer = 5;
    public UnityEvent OnTimerElapse;

    private bool isElapsed = false;

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && !isElapsed)
            {
                isElapsed = true;
                OnTimerElapse.Invoke();
            }
        }
    }
}
