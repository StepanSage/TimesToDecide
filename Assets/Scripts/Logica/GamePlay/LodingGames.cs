using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LodingGames : MonoBehaviour
{
    [SerializeField] private Image _loadBar;
    [SerializeField] private int _IDSence = 1;

    private AsyncOperation _asyncOperation;
    private float _dalay = 0.9f;


    private void Start()
    {
        StartCoroutine(LoadSenceCor());
    }

     IEnumerator LoadSenceCor()
    {
        yield return new WaitForSeconds(1f);
        _asyncOperation = SceneManager.LoadSceneAsync(_IDSence);
       
        while (!_asyncOperation.isDone) 
        {
            float progress = _asyncOperation.progress / _dalay;
            _loadBar.fillAmount= progress;
            yield return 0;
        }

    }




}
