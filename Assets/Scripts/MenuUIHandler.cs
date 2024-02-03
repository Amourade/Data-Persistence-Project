using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField NameInput;
    // Start is called before the first frame update

    public void StartNewGame()
    {
        MainManager.Instance.Name = NameInput.text;
        SceneManager.LoadScene("main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
