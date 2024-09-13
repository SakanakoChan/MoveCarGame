using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetGame()
    {
        StartCoroutine(ResetGame_Coroutine());
    }

    private IEnumerator ResetGame_Coroutine()
    {
        yield return new WaitForSeconds(0f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
