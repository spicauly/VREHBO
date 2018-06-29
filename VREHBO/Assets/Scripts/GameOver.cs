using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void Update()
    {
        StartCoroutine(SceneSwitch());
    }

    private IEnumerator SceneSwitch()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(1);
    }
}
