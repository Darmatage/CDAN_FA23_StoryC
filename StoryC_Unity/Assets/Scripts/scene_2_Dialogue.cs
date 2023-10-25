using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_2_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar2a;
       public GameObject ArtChar3a;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
		
		public GameObject NextScene1_rampage;
        public GameObject NextScene2_rampage;
        public GameObject NextScene3_rampage;
		
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
ArtChar2a.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
		
		NextScene1_rampage.SetActive(false);
        NextScene2_rampage.SetActive(false);
        NextScene3_rampage.SetActive(false);
		
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       Next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                //ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "*Yawn* I’m still not used to being up at such a late hour working";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "And in this place no less. I mean, talk about a “graveyard shift”, am I right?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         //ArtChar1a.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "hahaha……..jeez, tough crowd";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Sweet mother of god, fuckin ghosts!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
         ArtChar1a.SetActive(true);
                Char1name.text = "Farmer";
                Char1speech.text = "All that yammerin of yours woke me the hell up, boy!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
 ArtChar1a.SetActive(false);
         ArtChar2a.SetActive(true);
                Char1name.text = "Actor";
                Char1speech.text = "And your horrifyingly shrill voice is unbearable!";
                Char2name.text = "";
                Char2speech.text = "";
              }
      else if (primeInt ==8){
       ArtChar1a.SetActive(false);
               ArtChar2a.SetActive(false);
               ArtChar3a.SetActive(true);
                      Char1name.text = "Accountant";
                      Char1speech.text = "I never sleep…..";
                      Char2name.text = "";
                      Char2speech.text = "";
                    }
      else if (primeInt ==9){
             ArtChar1a.SetActive(false);
                     ArtChar2a.SetActive(true);
                     ArtChar3a.SetActive(false);
                            Char1name.text = "Actor";
                            Char1speech.text = "How am I ever going to rest in peace now?!";
                            Char2name.text = "";
                            Char2speech.text = "";
        }
       else if (primeInt == 10){
        ArtChar1a.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar3a.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Fellas, please, one at a time! And keep your voices down, its 10pm, people are trying to get some sleep";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(true);
                allowSpace = false;
                //Choice1a.SetActive(true); // function Choice1aFunct()
                //Choice1b.SetActive(true); // function Choice1bFunct()
              }
             else if (primeInt == 21){
                      Char1name.text = "Narrator";
                      Char1speech.text = "You have upset the poor resting souls of this plot. You must calm them down before they start harassing the people of the town";
                      Char2name.text = "";
                      Char2speech.text = "";
                      nextButton.SetActive(false);
                      allowSpace = false;
                      NextScene1Button.SetActive(true);
                    }
                   else if (primeInt == 21){
                            Char1name.text = "Narrator";
                            Char1speech.text = "Who will you meet with first?";
                            Char2name.text = "";
                            Char2speech.text = "";
                            nextButton.SetActive(false);
                            allowSpace = false;
                            NextScene1Button.SetActive(true);
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Then you are no use to me, and must be silenced.";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know what you're talking about!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, anything you want... just lay off the club.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("scene_3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("scene_4");
        }

        public void SceneChange3(){
                SceneManager.LoadScene("scene_5");
        }
		
		 public void SceneChange1_rampage(){
               SceneManager.LoadScene("scene_6");
        }
        public void SceneChange2_rampage(){
                SceneManager.LoadScene("scene_7");
        }

        public void SceneChange3_rampage(){
                SceneManager.LoadScene("scene_9");
        }

}
