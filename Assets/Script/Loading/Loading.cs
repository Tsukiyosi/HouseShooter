using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Loading : MonoBehaviour
{
    private TMP_Text loadingText;
    void Start()
    {
        loadingText = GetComponent<TMP_Text>();
        StartCoroutine("LoadingCoroutine");
    }


    IEnumerator LoadingCoroutine(){
        loadingText.text = "Loading";
        yield return new WaitForSeconds(1);

        loadingText.text = "Loading.";
        yield return new WaitForSeconds(1);

        loadingText.text = "Loading..";
        yield return new WaitForSeconds(1);

        loadingText.text = "Loading...";
        yield return new WaitForSeconds(1);

        StartCoroutine("LoadingCoroutine");
    }
}
