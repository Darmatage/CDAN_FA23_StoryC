using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
               
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hello? Who is this?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		    ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Hello are you the new guy? You at the graveyard yet?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I am at the graveyard. \nIs there anybody I am supposed to talk to?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "The only one you gonna be talking to is me, pal.";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "All you need to know is that I pay you.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "This graveyard is a mess dude!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		  else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Yeah, which why we hired you dummy, go clean.";
        }
		  else if (primeInt ==9){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()  Yes, sir.
                Choice1b.SetActive(true); // function Choice1bFunct()  Isn't it haunted?
        }
		
		
		// after choice 1a
       else if (primeInt == 20){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Boss";
			Char2speech.text = "Tools are in the shed. \nKeep your eyes open. \nDon't break my tools.";
        }
       else if (primeInt == 21){
			Char1name.text = "YOU";
			Char1speech.text = "OK, um, if I have a questions, should I...";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 39;
        } 


       // after choice 1b
        else if (primeInt ==30){
                Char1name.text = "YOU";
                Char1speech.text = "We never discussed my hazard pay. \nI mean I've heard this place is haunted...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		  else if (primeInt ==31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Well dont worry about that, kiddo. \nJust keep the place clean and you won't have any, uh... 'problems' hehe.";
        }
		
		  else if (primeInt ==32){
                Char1name.text = "YOU";
                Char1speech.text = "What does that mean?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		  else if (primeInt ==33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Look, just try not to cause trouble.";
        }
		 else if (primeInt ==34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Folks here like their dead resting peacefully, if you know what I mean.";
        }
		 else if (primeInt ==35){
                Char1name.text = "YOU";
                Char1speech.text = "Wait what do you mean, 'peacefully'?";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 39;
        }
	   
	   
	   //scene ends		 
	   else if (primeInt ==40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Just get to work, kid. I gotta go.";
      
        }
		
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Boss";
                Char2speech.text = "Thirsty Thursday aint gonna get itself started eh? \nHehehehehe *click*";
                // Go to next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
	   

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, sir, you are in good hands!";
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
                Char1speech.text = "Hold on a minute.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_2");
        }
        //public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        //}
}