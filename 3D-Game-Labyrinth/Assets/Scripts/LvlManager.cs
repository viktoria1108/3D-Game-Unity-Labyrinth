using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    //перезапуск гри
    public static void Restart() => SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

    //перехід на новий рівень
    public static void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 == 3)
            SceneManager.LoadSceneAsync(0);
        else
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
