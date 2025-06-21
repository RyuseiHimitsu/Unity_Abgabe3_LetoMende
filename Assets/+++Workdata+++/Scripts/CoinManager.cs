using UnityEngine;

public class CoinManager : MonoBehaviour
{
    #region defining

    public int coinCounter;
    public UIManager uIManager;
    
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
        }
        //if collision object doesDamage, show lost Panel and destroy player
        if (other.CompareTag("DoesDamage"))
        {
            Destroy(gameObject);
            uIManager.OpenLostPanel();
        }
    }

}
