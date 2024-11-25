using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    
    public class MainUIController : MonoBehaviour
    {
        [Tooltip("A collection of UI panels, one of which will be active at a time.")]
        public GameObject[] panels;

        
        public void SetActivePanel(int index)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                bool active = i == index;
                GameObject panel = panels[i];
                if (panel.activeSelf != active)
                    panel.SetActive(active);
            }
        }

        public void GoSampleScene() {
            SceneManager.LoadScene("SampleScene");
        }

        public void GoMenuScene() {
            SceneManager.LoadScene("MainMenuScene");
        }

        void OnEnable()
        {
            SetActivePanel(0);
        }
    }
}