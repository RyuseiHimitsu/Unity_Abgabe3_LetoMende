using UnityEngine;

public class CoinManager : MonoBehaviour
{
    #region defining

    public float coinCounter;
    public UIManager uIManager;
    public Timer timer;
    public float Highscore;
    public float TimeScore;
    
    #endregion
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if collision object is coin/diamond, add 1 or 5 to the score count
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinCounter++;
        }
        if (other.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
            coinCounter = coinCounter + 5;
            GetHighscore();
        }
        //if collision object doesDamage, show lost Panel and destroy player
        if (other.CompareTag("DoesDamage"))
        {
            Destroy(gameObject);
            uIManager.OpenLostPanel();
        }
    }

    private void GetHighscore()
    {
        TimeScore = timer.elapsedTime * 10;
        coinCounter = coinCounter * 10;
        Highscore = coinCounter + TimeScore;
        Debug.Log(Highscore);
    }

}
