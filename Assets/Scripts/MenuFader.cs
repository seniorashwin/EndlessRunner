using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuFader : MonoBehaviour
{
    public float fadeDuration = 1f;
    private Image _panelImage;
    
    public SceneTransition sceneTransition;

    void Start()
    {
        _panelImage = GetComponent<Image>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float alpha = 1;
        while (alpha > 0)
        {
            alpha -= Time.deltaTime / fadeDuration;
            _panelImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        gameObject.SetActive(false); // Disable after fade
    }

    public void PlayGame()
    {
        sceneTransition.LoadScene("GameScene"); 
    }
}

