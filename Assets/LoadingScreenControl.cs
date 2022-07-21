using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenControl : MonoBehaviour
{
    public GameObject loadingScreenObj;
    public Slider slider;
    public Text progressText;


    public void LoadScreenExample(int sceneIndex)
    {
        StartCoroutine(LoadingScreen(sceneIndex)) ;
    }


    IEnumerator LoadingScreen(int sceneIndex)
    {
        loadingScreenObj.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            slider.value = progress;
            progressText.text = progress * 100+ "%";
             
            yield return null;
        }
    }
}
