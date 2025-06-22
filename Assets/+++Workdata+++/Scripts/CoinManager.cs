using System;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinManager : MonoBehaviour
{
    #region defining

    public float coinCounter;
    public UIManager uIManager;
    public Timer timer;
    public float Highscore;
    public float TimeScore;
    public int DiamondCounter;
    public TextMeshProUGUI ScoreText;
    
    #endregion

    private void Update()
    {
        ScoreText.text = Highscore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if collision object is coin/diamond, add 1 or 5 to the score count
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinCounter += 50;
        }
        if (other.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
            coinCounter = coinCounter + 200;
            DiamondCounter++;
            GetHighscore();
            if (DiamondCounter == 3)
            {
                uIManager.OpenWinPanel();
            }
        }
        //if collision object doesDamage, show lost Panel and destroy player
        if (other.CompareTag("DoesDamage"))
        {
            uIManager.OpenLostPanel();
        }
    }

    private void GetHighscore()
    {
        TimeScore = Highscore - timer.elapsedTime;
        Highscore = coinCounter + TimeScore;
        Debug.Log(Highscore);
    }

}
