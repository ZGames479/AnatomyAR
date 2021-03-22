using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeleBtns : MonoBehaviour
{

    #region Menu Dialogs
    [Header("UI Panels")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject skullPanel;
    [SerializeField] private GameObject ribcagePanel;
    [SerializeField] private GameObject spinePanel;
    [SerializeField] private GameObject pelvisPanel;
    [SerializeField] private GameObject humerusPanel;
    [SerializeField] private GameObject radiusPanel;
    [SerializeField] private GameObject ulnaPanel;
    [SerializeField] private GameObject phalangesPanel;
    [SerializeField] private GameObject femurPanel;
    [SerializeField] private GameObject tibiaPanel;
    [SerializeField] private GameObject fibulaPanel;
    [SerializeField] private GameObject patellaPanel;

    [Space(10)]
    [Header("Buttons")]
    [SerializeField] private GameObject mainMenuBtn;
    #endregion

    void Start()
    {
        mainMenuBtn.SetActive(true);
        mainMenu.SetActive(false);
        skullPanel.SetActive(false);
        ribcagePanel.SetActive(false);
        spinePanel.SetActive(false);
        pelvisPanel.SetActive(false);
        humerusPanel.SetActive(false);
        radiusPanel.SetActive(false);
        ulnaPanel.SetActive(false);
        phalangesPanel.SetActive(false);
        femurPanel.SetActive(false);
        tibiaPanel.SetActive(false);
        fibulaPanel.SetActive(false);
        patellaPanel.SetActive(false);
    }

    public void MouseClick(string buttonType)
    {
        if (buttonType == "mainMenu")
        {
            mainMenu.SetActive(true);
            mainMenuBtn.SetActive(false);
        }

        if (buttonType == "skull")
        {
            mainMenu.SetActive(false);
            skullPanel.SetActive(true);
        }

        if (buttonType == "ribcage")
        {
            mainMenu.SetActive(false);
            ribcagePanel.SetActive(true);
        }

        if (buttonType == "spine")
        {
            mainMenu.SetActive(false);
            spinePanel.SetActive(true);
        }

        if (buttonType == "pelvis")
        {
            mainMenu.SetActive(false);
            pelvisPanel.SetActive(true);
        }

        if (buttonType == "humerus")
        {
            mainMenu.SetActive(false);
            humerusPanel.SetActive(true);
        }

        if (buttonType == "radius")
        {
            mainMenu.SetActive(false);
            radiusPanel.SetActive(true);
        }

        if (buttonType == "ulna")
        {
            mainMenu.SetActive(false);
            ulnaPanel.SetActive(true);
        }

        if (buttonType == "phalanges")
        {
            mainMenu.SetActive(false);
            phalangesPanel.SetActive(true);
        }

        if (buttonType == "femur")
        {
            mainMenu.SetActive(false);
            femurPanel.SetActive(true);
        }

        if (buttonType == "tibia")
        {
            mainMenu.SetActive(false);
            tibiaPanel.SetActive(true);
        }

        if (buttonType == "fibula")
        {
            mainMenu.SetActive(false);
            fibulaPanel.SetActive(true);
        }

        if (buttonType == "patella")
        {
            mainMenu.SetActive(false);
            patellaPanel.SetActive(true);
        }

        if (buttonType == "close")
        {
            mainMenu.SetActive(true);
            skullPanel.SetActive(false);
            ribcagePanel.SetActive(false);
            spinePanel.SetActive(false);
            pelvisPanel.SetActive(false);
            humerusPanel.SetActive(false);
            radiusPanel.SetActive(false);
            ulnaPanel.SetActive(false);
            phalangesPanel.SetActive(false);
            femurPanel.SetActive(false);
            tibiaPanel.SetActive(false);
            fibulaPanel.SetActive(false);
            patellaPanel.SetActive(false);
        }

        if (buttonType == "closeMainMenu")
        {
            mainMenu.SetActive(false);
            mainMenuBtn.SetActive(true);
        }
    }
}