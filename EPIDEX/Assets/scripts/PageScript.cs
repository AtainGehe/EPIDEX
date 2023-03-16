using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageScript : MonoBehaviour
{
    [SerializeField] GameObject mainPage;
    [SerializeField] GameObject pokePage;
    public void ShowPage() {
        mainPage.SetActive(false);
        pokePage.SetActive(true);
    }

    public void HidePage() {
       mainPage.SetActive(true);
        pokePage.SetActive(false);
    }

    void Start() {
        Input.backButtonLeavesApp = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            HidePage();
        }
    }

}
