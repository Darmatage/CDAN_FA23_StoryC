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
		
		if ((GameHandler.metghost1)||(GameHandler.metghost2)||(GameHandler.metghost3)){
			primeInt = 99;
			
		}
		
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
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() Shut up!
                Choice1b.SetActive(true); // function Choice1bFunct() OK, I will help
              }




       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "Fellas, keep your voices down! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "It's 10pm, people are trying to get some sleep";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "OK. Ugh. Which of you creeps will I choose to speak with first?";
                Char2name.text = "";
                Char2speech.text = "";
			primeInt=109;
        }


       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "YOU";
                Char1speech.text = "Lets all settle down, guys, and keep down the ruckus! \nMy boss will get mad!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "This makes my job more intresting, let me help!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 32){
                Char1name.text = "YOU";
                Char1speech.text = "OK, which of you will I choose to speak with first?";
                Char2name.text = "";
                Char2speech.text = "";
			primeInt=109;
        }




//dialogue when returning to graveyard from a ghost encounter
		else if (primeInt == 100){
			ArtChar1a.SetActive(false);
			ArtChar2a.SetActive(false);
			ArtChar3a.SetActive(false);
			
                Char1name.text = "YOU";
                Char1speech.text = "Alright. Back in the graveyard.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "Who's next?";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt=109;
        }
		
//choose a ghost to visit
       else if (primeInt == 110){
		   DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				//
                nextButton.SetActive(false);
                allowSpace = false;
				
				if (GameHandler.metghost1 == false){
					ArtChar1a.SetActive(true);
					NextScene1Button.SetActive(true);
				}
				if (GameHandler.metghost2 == false){
					ArtChar2a.SetActive(true);
					NextScene2Button.SetActive(true);
				}
				
				if (GameHandler.metghost3 == false){
					ArtChar3a.SetActive(true);
					NextScene3Button.SetActive(true);
				}
				
				if (GameHandler.ghost1rampage== true){
					ArtChar1a.SetActive(false);
					NextScene1_rampage.SetActive(true);
				}
				if (GameHandler.ghost2rampage == true){
					ArtChar2a.SetActive(false);
					NextScene2_rampage.SetActive(true);
				}
				if (GameHandler.ghost3rampage == true){
					ArtChar3a.SetActive(false);
					NextScene3_rampage.SetActive(true);
				}	
				
        }










      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Crap, you are loud!";
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
                Char1speech.text = "Woah -- not so loud, OK?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("scene_3"); // farmer
        }
        public void SceneChange2(){
                SceneManager.LoadScene("scene_4");//actor
        }

        public void SceneChange3(){
                SceneManager.LoadScene("scene_5");//accountant
        }
		
		 public void SceneChange1_rampage(){ // farmer rampage
               SceneManager.LoadScene("scene_6");
        }
        public void SceneChange2_rampage(){// acotr rampage
                SceneManager.LoadScene("scene_7");
        }

        public void SceneChange3_rampage(){//acountant rampage
                SceneManager.LoadScene("scene_9");
        }

}
