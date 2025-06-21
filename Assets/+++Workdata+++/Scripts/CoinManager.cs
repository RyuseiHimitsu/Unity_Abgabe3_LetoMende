using UnityEngine;

public class CoinManager : MonoBehaviour
{
    #region defining

    public int coinCounter;
    public UIManager uIManager;
    
    #endregion
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered a trigger" + other.name);

        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinCounter++;
        }

        if (other.CompareTag("DoesDamage"))
        {
            Destroy(gameObject);
            uIManager.OpenLostPanel();
        }
    }

}
