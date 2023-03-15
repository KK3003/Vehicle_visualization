using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public GameObject colorPallete;
    public GameObject interactPanel;
    public GameObject modifyPanel;
    bool ison, isOpen, isModify;

    
    public void ColorChange()
    {
        if(ison)
        {
            ison = false;
            colorPallete.SetActive(true);
        }
        else
        {
            ison = true;
            colorPallete.SetActive(false);
            
        }    
    }

    public void Interact()
    {
        if (isOpen)
        {
            isOpen = false;
            interactPanel.SetActive(true);
        }
        else
        {
            isOpen = true;
            interactPanel.SetActive(false);

        }
    }

    public void Modify()
    {
        if (isOpen)
        {
            isModify = false;
            modifyPanel.SetActive(true);
        }
        else
        {
            isModify = true;
            modifyPanel.SetActive(false);
        }
    }
}
