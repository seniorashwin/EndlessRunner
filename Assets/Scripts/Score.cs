using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text _scoreText;
    private float _score = 0f;

    void Start()
    {
        // Find the ScoreText inside the Canvas
        GameObject scoreObj = GameObject.Find("ScoreText");

        if (scoreObj != null)
        {
            _scoreText = scoreObj.GetComponent<Text>();
        }
        else
        {
            Debug.LogError("⚠️ 'ScoreText' object not found! Make sure the text object is inside the Canvas and named 'ScoreText'.");
        }
    }

    void Update()
    {
        if (_scoreText != null)
        {
            _score += Time.deltaTime;
            _scoreText.text = "Score: " + Mathf.FloorToInt(_score);
        }
    }
}