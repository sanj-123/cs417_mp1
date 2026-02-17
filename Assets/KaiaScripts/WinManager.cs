using UnityEngine;


public class WinManager : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gate1;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gate2;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gate3;
    public GameObject youWinObject;

    void Start()
    {
        if (youWinObject != null) youWinObject.SetActive(false);
    }

    void Update()
    {
        if (gate1 != null && gate2 != null && gate3 != null &&
            gate1.hasSelection && gate2.hasSelection && gate3.hasSelection)
        {
            if (youWinObject != null) youWinObject.SetActive(true);
        }
    }
}
