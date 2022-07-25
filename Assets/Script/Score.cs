using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float number;
    [SerializeField]
    private Text numberText;
    [SerializeField]
    private Text finishText;
    [SerializeField]
    // Start is called before the first frame update
    void Update()
    {
        number += Time.deltaTime;
        numberText.text = "" + (int)number;

        finishText.text = "" + (int)number;
    }

}
