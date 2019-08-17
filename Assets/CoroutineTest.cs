using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoroutineTest : MonoBehaviour
{
    int iLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene());
        
        
    }

    IEnumerator ShowLog()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("2");        
        yield return new WaitForSeconds(1.0f);
        Debug.Log("3");
    }

    IEnumerator NextScene()
    {
        yield return new WaitUntil(() => iLevel >= 600);
        SceneManager.LoadScene("navi");
    }

    // Update is called once per frame
    void Update()
    {
        iLevel++;
    }
}
