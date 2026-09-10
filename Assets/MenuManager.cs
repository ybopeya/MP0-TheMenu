using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject creditsCanvasPrefab;

    public void ShowCredits()
    {
        Instantiate(creditsCanvasPrefab);
    }
}