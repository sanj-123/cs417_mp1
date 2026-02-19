using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class collision_script : MonoBehaviour
{
    public game_manager manager;
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    private bool triggered = false;
    
    void Awake()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    void OnEnable()
    {
        socket.selectEntered.AddListener(OnInserted);
    }
    
    void OnDisable()
    {
        socket.selectEntered.RemoveListener(OnInserted);
    }
    
    private void OnInserted(SelectEnterEventArgs args)
    {
        if (triggered) return;
        triggered = true;
        if (manager != null) manager.addSolved();
    }

}