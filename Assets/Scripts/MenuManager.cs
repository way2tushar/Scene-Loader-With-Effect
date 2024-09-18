using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using way2tushar.Utility;

public class MenuManager : MonoBehaviour
{
    public void OnClickBtn(string sceneName)
    {
        StartCoroutine(SceneLoader.Instance.LoadScene(sceneName));
    }
}
