using TMPro;
using Unity.Mathematics.Geometry;
using UnityEngine;
using UnityEngine.Timeline;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float elapsedTime;
    public bool gamePaused;

    // Update is called once per frame
    void Update()
    {
        if (gamePaused == false)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
