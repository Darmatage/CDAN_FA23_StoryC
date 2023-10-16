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
        public GameObject NextScene2Button;
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
        NextScene2Button.SetActive(false);
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
       /Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
				
				if ((GameHandler.metghost1==false)&&(GameHandler.metghost3==false)){
					Char1speech.text = "Wait what the hell? We were just in the graveyard! What's going on?";
				} else {
					Char1speech.text = "Oh so this is what actual Hell looks like. Neat.";
				} 
				
                Char2name.text = "";
                Char2speech.text = "";
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Don’t mind the mess, it gets a little crazy here sometimes.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "I'm a bit of a party animal if you couldn't tell.";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "...Sure...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Anyways, I've taken the liberty of looking at your employer's finances and I must say I am quite intrested";
      

 }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Wait what how did you???...";
                Char2name.text = "";
                Char2speech.text = "";
			
			
			 }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
            Char2speech.text = "It seems that your employer is fudging the books a little, if you know what I mean.";
	   }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "I don't";
                Char2name.text = "";
                Char2speech.text = "";
	  }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Oh no, you're a simpleton. That explains your paystub";
	  }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Hey!";
                Char2name.text = "";
                Char2speech.text = "";
	  }
	  
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Tell me, rube, have you claimed that uniforma you're wearing as a business related expense in your most recent tax submission?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct():Of course!
                Choice1b.SetActive(true); // function Choice1bFunct():NO....
        }

       // after choice 1a (Of course!)
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Oh really?";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "YOU";
                Char2name.text = "Yeah man,don't sweat it! I totally did that thing you just said.";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
 }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Proof of pruchase? Credit card statemen? From 32-C-A_54:CRT?";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);       
	    }
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah man! All of that!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
	   }
	    else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				Choice2a.SetActive(true); // function Choice1aFunct():More needs to be written in script
                Choice2b.SetActive(true); // function Choice1bFunct():More needs to be written in script
	   }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "I thought as much. One look at those glassy, empty eyes told me everything I needed to know.";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Now just wait a minute!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
		 }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "Silnce. I'm working";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);		
        }
       else if (primeInt == 33){
                Char1name.text = "YOU";
                Char1speech.text = "....";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
		 }
       else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
	 }
       else if (primeInt == 35){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "There, I’ve added all the relevant information to your tax statement in an addendum.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
				 }
       else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Accountant";
                Char2speech.text = "You need to make sure you catch these kinds of things next time";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
				 }
       else if (primeInt == 37){
                Char1name.text = "YOU";
                Char1speech.text = "";
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
                Char1speech.text = "Yeah of course! I mean, who hasnt? Amirite?";
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
                Char1speech.text = "Uhm,well...no...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}