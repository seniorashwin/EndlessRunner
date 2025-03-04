using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainMenuManager : MonoBehaviour
{
    public Image transitionPanel; // Assign your UI Panel here
    public float fadeDuration = 1f;

    void Start()
    {
        transitionPanel.gameObject.SetActive(true); // Ensure the panel is active
        transitionPanel.color = new Color(0, 0, 0, 1); // Start fully black
        StartCoroutine(FadeIn()); // Fade into the main menu
    }

    public void PlayGame()
    {
        StartCoroutine(FadeOut("GameScene")); // Fades out before switching scenes
        Debug.Log("✅ Play Button Clicked!"); // This should appear in the Console
        StartCoroutine(FadeOut("GameScene"));
    }

    IEnumerator FadeIn()
    {
        float alpha = 1f;
        while (alpha > 0)
        {
            alpha -= Time.deltaTime / fadeDuration;
            transitionPanel.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        transitionPanel.color = new Color(0, 0, 0, 0); // Fully transparent
    }

    IEnumerator FadeOut(string sceneName)
    {
        float alpha = 0f;
        transitionPanel.gameObject.SetActive(true); // Show panel for fade-out

        while (alpha < 1)
        {
            alpha += Time.deltaTime / fadeDuration;
            transitionPanel.color = new Color(0, 0, 0, alpha);
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
    
}