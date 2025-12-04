using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetTextActive : MonoBehaviour
{
    public GameObject textPrivacy;
    public GameObject textSecurity;

    public GameObject activeStatePrivacy;
    public GameObject activeStateSecurity;

    public Button startButton;

    void Update()
    {
        // calls for the 2 scripts to activate when the startbutton is pressed
        
        ActivateTextPrivacy();
        ActivateTextSecurity();
    }

    
    /// <summary>
    /// activate the text based on which of the gameobjects is active, the privacy object or the security one.
    /// </summary>
    void ActivateTextPrivacy()
    {
        if (activeStatePrivacy.activeInHierarchy == true)
        {
            Debug.Log("test");
            textPrivacy.SetActive(true);
        }

        if (activeStatePrivacy.activeInHierarchy == false)
        {
            Debug.Log("test failed");
        }
    }

    void ActivateTextSecurity()
    {
        if (activeStateSecurity.activeInHierarchy == true)
        {
            Debug.Log("Other test");
            textSecurity.SetActive(true);

        }
    }




}
