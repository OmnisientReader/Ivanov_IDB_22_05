using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterDec : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    public int counter = 100;

    private void OnTriggerEnter(Collider other)
    {
        counter--;
        text.text = $"counter\n  {counter}";//Convert.ToString(counter);

    }

    // Update is called once per frame
    //void Update()
    //{
    //    text.text = $"counter\n  {counter}";//Convert.ToString(counter);


    //}
}
