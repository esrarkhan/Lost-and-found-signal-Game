using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SignalCollect : MonoBehaviour
{
    public Slider signalBar;
    public TextMeshProUGUI messageText;

    public int signalAmount = 50;

    private int currentSignal = 0;
    private int maxSignal = 100;

    void Start()
    {
        signalBar.minValue = 0;
        signalBar.maxValue = maxSignal;
        signalBar.value = 0;

        if (messageText != null)
        {
            messageText.text = "";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touched: " + other.name);

        if (other.CompareTag("Signal"))
        {
            currentSignal += signalAmount;

            if (currentSignal > maxSignal)
            {
                currentSignal = maxSignal;
            }

            signalBar.value = currentSignal;

            Destroy(other.gameObject);

            if (currentSignal >= maxSignal)
            {
                messageText.text = "Signal has been restored successfully!";
            }
            else
            {
                messageText.text = "Signal collected!";
            }
        }
    }
}
