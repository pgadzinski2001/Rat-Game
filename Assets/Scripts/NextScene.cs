using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GoToNextScene());
    }

    void Update()
    {
        
    }

    IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(10.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
