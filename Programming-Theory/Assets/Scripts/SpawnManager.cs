using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballsPrefabs;
    public Button redButton;
    public Button yellowButton;
    public Button blueButton;

    public void DisableButtons()
    {
        //Abstraction
        redButton.gameObject.SetActive(false);
        yellowButton.gameObject.SetActive(false);
        blueButton.gameObject.SetActive(false);
    }

    public void SpawnRed()
    {
        Instantiate(ballsPrefabs[0], ballsPrefabs[0].transform.position, ballsPrefabs[0].transform.rotation);
        DisableButtons();
    }

    public void SpawnYellow()
    {
        Instantiate(ballsPrefabs[1], ballsPrefabs[1].transform.position, ballsPrefabs[1].transform.rotation);
        DisableButtons();
    }

    public void SpawnBlue()
    {
        Instantiate(ballsPrefabs[2], ballsPrefabs[2].transform.position, ballsPrefabs[2].transform.rotation);
        DisableButtons();
    }
}
