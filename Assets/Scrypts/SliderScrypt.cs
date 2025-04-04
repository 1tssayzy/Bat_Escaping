using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScrypt : MonoBehaviour
{ 
    [SerializeField] private Slider volumeSlider;
 
    void Start()
    {
       if(!PlayerPrefs.HasKey("musicVolume")){
        PlayerPrefs.SetFloat("musicVolume", 1f);
       Load(); 
         } else {
            Load();
         }

  }
   
    public void ChangeVolume () {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
