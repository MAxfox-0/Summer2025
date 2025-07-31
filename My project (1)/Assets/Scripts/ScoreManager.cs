using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance { get; private set; }

    // UI text component to display count of "PickUp" objects collected.
    public TextMeshProUGUI countText;

    // UI object to display winning text.
    public GameObject winTextObject;

    public GameObject loseTextObject;

    private int points = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);

    }

    public void AddToPoints(int value)
    {
        points += value;
        SetCountText();
    }
    // Function to update the displayed count of "PickUp" objects collected.
    private void SetCountText()
    {
        // Update the count text with the current count.
        countText.text = "Count: " + points.ToString();

        // Check if the count has reached or exceeded the win condition.
        if (points >= 12)
        {
            // Display the win text.
            winTextObject.SetActive(true);
        }
    }

    public int GetPoints()
    {
        return points;   
    }

    public void SetPoints(int value)
    {
        points = value;
        SetCountText();
    }
}
