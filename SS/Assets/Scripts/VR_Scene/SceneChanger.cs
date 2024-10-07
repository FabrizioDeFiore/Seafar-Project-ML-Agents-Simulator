using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; 
using UnityEngine;

public class SceneChanger : MonoBehaviour
{/*
    [SerializeField] private string scene1 = "Seafar_AI_Simulator_1.0"; 
    [SerializeField] private string scene2 = "Seafar_AI_Simulator_2.0"; 
    [SerializeField] private string scene3 = "Seafar_VR_V1.5"; 
    [SerializeField] private string scene4 = "Seafar_VR_V2"; 


    void Update(){
        if (Input.GetKeyDown(KeyCode.Z)){
            SceneManager.LoadScene(scene1);
        }
        if (Input.GetKeyDown(KeyCode.X)){
            SceneManager.LoadScene(scene2);
        }
        if (Input.GetKeyDown(KeyCode.C)){
            SceneManager.LoadScene(scene3);
        }
        if (Input.GetKeyDown(KeyCode.V)){
            SceneManager.LoadScene(scene4);
        }
    }
    */
    [SerializeField] private InputActionReference nextSceneButton;
    [SerializeField] private InputActionReference previousSceneButton;

    private void Awake()
    {
        nextSceneButton.action.performed += OnNextSceneButton;
        previousSceneButton.action.performed += OnPreviousSceneButton;
    }

    private void OnDestroy()
    {
        nextSceneButton.action.performed -= OnNextSceneButton;
        previousSceneButton.action.performed -= OnPreviousSceneButton;
    }

    private void OnNextSceneButton(InputAction.CallbackContext context)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    private void OnPreviousSceneButton(InputAction.CallbackContext context)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = currentSceneIndex - 1;

        if (previousSceneIndex >= 0)
        {
            SceneManager.LoadScene(previousSceneIndex);
        }
    }

}
