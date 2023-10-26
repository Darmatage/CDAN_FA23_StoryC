using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_10_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		 public Text Char3speech;
		 public Text Char4name;
		  public Text Char4speech;
        public GameObject DialogueDisplay;
		
		
        public GameObject ArtChar1a; //accountant happy
		public GameObject ArtChar1b;//accountant talking
       public GameObject ArtChar_wife; //wife
	     public GameObject ArtChar_son; //son
	   
	   
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		  public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
	  ArtChar1b.SetActive(false);
	    ArtChar_wife.SetActive(false);
		   ArtChar_son.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "So, this is where your family lives now huh? Kinda empty";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Things must've been hard for my family if they live here";
                Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "Lyda";
                Char1speech.text = "AHHH!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "AHH!!!!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "Lydia: Who are you?! How did you get into my house?!";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
     // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(Jerry told me you lived here!)
                Choice1b.SetActive(true); // function Choice1bFunct(Your husband is here to see you!)
	   }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lydia";
                Char2speech.text = "What? Why would he tell you that?!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				
        }
		  else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "He wanted me to give you something?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lydia";
                Char2speech.text = "I don't trust you. Now get out my house!!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
	
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "NOT THE FACE!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				//bad ending ^^^^
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Lydia, it's me, Michael";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 31){
                Char1name.text = "Lydia";
                Char1speech.text = "Is it really... you?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "I'm the same boring accountant you still married all those years ago";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 33){
                Char1name.text = "Lydia";
                Char1speech.text = "It's been so hard without you, Mitch. Not just with money. I've been so alone.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "I didn't mean to leave you like this. I should have stayed home that day";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 35){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "If I had, the car crash would have never happened and I'd still be alive.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 36){
                Char1name.text = "Lydia";
                Char1speech.text = "I don't blame you sweetie. You were just trying to provide for us.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 37){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jr";
                Char2speech.text = "Mom... W-who is that man in our-";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 38){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jr";
                Char2speech.text = "Daddy?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 39){
                Char1name.text = "Ghost Accountant";
                Char1speech.text = "Jr?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jr";
                Char2speech.text = "Dad! What happened to you?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 41){
                Char1name.text = "Ghost Accountant";
                Char1speech.text = "I've passed away son, son. But this kid over here gave me a chance to see you again.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lydia";
                Char2speech.text = "I'm just glad we saw you again Michael.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 43){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Okay, Will you coe back to the Graveyard?";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 44){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Yeah kid. Sorry for the trouble. I can rest now";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				//^^^ good ending
                nextButton.SetActive(false);
                allowSpace = false;
               
				
				if ((GameHandler.metghost1==true)&&(GameHandler.metghost2==true)){
					NextScene3Button.SetActive(true);	//end win
				}else{
					NextScene2Button.SetActive(true);	 //graveyard
				}
				
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Jerry told me you lived here!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Your husband is here to see you!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){  //bad ending
               SceneManager.LoadScene("End_Lose");
        }
        public void SceneChange2(){
			GameHandler.ghost3rampage = false;
                SceneManager.LoadScene("scene_2"); //return to graveyard
        }
		        public void SceneChange3(){
                SceneManager.LoadScene("End_Win");
        }
		
		
}