using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using TMPro;

public class ClickFocus : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI Score;
    int Value = 0;

    void Start()
    {

    }

    public void OnClick() 
    {
        Value += 1;

        Score.text = "Grana: " + Value;
    }



}
