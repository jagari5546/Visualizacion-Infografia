using UnityEngine;

public class StartPanel : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject exitButton;
    [SerializeField] private GameObject infoButton;
    [SerializeField] private GameObject context1;
    [SerializeField] private GameObject context2;
    [SerializeField] private GameObject regresar1;
    [SerializeField] private GameObject title1;
    [SerializeField] private GameObject piezas;
    [SerializeField] private GameObject title2;
    [SerializeField] private GameObject control;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        infoPanel.SetActive(true);
        exitButton.SetActive(false);
        infoButton.SetActive(false);
        context1.SetActive(false);
        context2.SetActive(false);
        regresar1.SetActive(false);
        title1.SetActive(true);
        title2.SetActive(false);
        piezas.SetActive(false);
        control.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseAplication()
    {
        Application.Quit();
    }
}


