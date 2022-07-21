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
            float Progress= Mathf.Floor(progress * 100);
            progressText.text = string.Format("Loading...:{0}%", Progress);
             
            yield return null;
        }
    }
}
