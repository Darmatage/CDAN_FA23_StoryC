using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_6_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
	public GameObject DialogueDisplay;
	public GameObject ArtChar1a; //fury
	public GameObject ArtChar1b; //mad
	public GameObject ArtChar1c; //talking
	public GameObject ArtChar1d; //happy
	   
	public GameObject ArtChar2; //farmer 1
	public GameObject ArtChar3; //famer 2
	public GameObject ArtChar4; //farmer 3
	public GameObject ArtChar5; //famer 4
	public GameObject ArtChar6; //famer 5	
	   
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
		public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		 public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){ 
		GameHandler.metghost1 = true;
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
		 Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
        GameHandler.metghost1 = true;
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
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "DUDE WHAT ARE YOU DOING?";
                Char2name.text = "";
                Char2speech.text = " ";
		Char3name.text = " ";
		Char3speech.text = " ";
	}
       else if (primeInt == 3){
                Char1name.text = " ";
                Char1speech.text = " ";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "LETS SEE HOW THEY LIKE LOSING EVERYTHING";
			Char3name.text = " ";
			Char3speech.text = " ";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = " ";
                Char2speech.text = " ";
			Char3name.text = "Background Farmer";
			Char3speech.text = "Run for you life!!!";
        }
       else if (primeInt == 5){
                Char1name.text = "Background Farmer 2";
                Char1speech.text = "My Crops!!! How could yoU!";
                Char2name.text = "";
                Char2speech.text = "";
			Char3name.text = " ";
			Char3speech.text = " ";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Stop, pleas! This won't change anything! You're only making things worse!";
			Char3name.text = " ";
			Char3speech.text = " ";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Ghost Farmer";
			    Char3speech.text = "I GUESS THAT'S WHAT I DO,HUH!?";
				ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(Calm down)
                Choice1b.SetActive(true); // function Choice1bFunct(What would your wife think)
        }
  

       // after choice 1a
       else if (primeInt == 20){
		   ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "A WHAT?!";
        }
       else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "A drink man. I've got some whiskey in my thermos, something to take the edge off";
                Char2name.text = "";
                Char2speech.text = "";
        
				 }
       else if (primeInt == 22){
		   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I AINT EVER GONNA TOUCH A DROP OF THAT FOUL STUFF AGAIN!";
	   }
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "What?!";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "NOW YOU'VE DONE IT BOY! OHHH YOU'VE MADE ME MAD!";
// bad ending after that^
				 }


       // after choice 1b
       else if (primeInt == 30){
		   ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I've done so much sin already, what's a little more! Where am I going to go? Hell?... ";
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "... I'm already here!";
				 }
       else if (primeInt == 32){
                Char1name.text = "YOU";
                Char1speech.text = "But what if you could see her again?";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 33){
		   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "What?";
				 }
       else if (primeInt == 34){
                Char1name.text = "YOU";
                Char1speech.text = "Your guilt and shame are holding you back...";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 35){
                Char1name.text = "YOU";
                Char1speech.text = "If you face your actions and stop holding onto the past...";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 36){
                Char1name.text = "YOU";
                Char1speech.text = "... Maybe you can move on from your purgatory. maybe you can see your family.";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 37){
		   ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "What would you know, boy?! Why should I trust you?";
      // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct(You can't, just trust me)
                Choice2b.SetActive(true); // function Choice2bFunct(I saw it in the bible)
	  }
  // after choice 2a
   
   else if (primeInt == 41){
	   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "What if you're wrong";
   }	  
	  else if (primeInt == 42){
                Char1name.text = "YOU";
                Char1speech.text = "What if I'm right?";
                Char2name.text = "";
                Char2speech.text = "";
	  }  
	  else if (primeInt == 43){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "But I've done so much harm...";
	  }
	   else if (primeInt == 43){
                Char1name.text = "YOU";
                Char1speech.text = "You were an addict, it's not all your fault";
                Char2name.text = "";
                Char2speech.text = "";
	  }
	  else if (primeInt == 44){
		  ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I hope you're right about this";
		nextButton.SetActive(false);
		allowSpace = false;
		if ((GameHandler.metghost2==false)||(GameHandler.metghost3==false)){
				NextScene2Button.SetActive(true); // back to graveyard to meet another ghost
		}	 else {
				NextScene3Button.SetActive(true); // all ghosts pacified. you win!
		}
	}	  			
	  
	  
	  
  // after choice 2b
   else if (primeInt == 50){
	   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "Ghost Farmer";
                Char1speech.text = "I read that Holy Book every night ‘fore bed and I aint never seen nothing like that in there! Sinners are rotten sinners and they will never change!";
                Char2name.text = "";
                Char2speech.text = "";
   }
//bad ending   

						
	//Please do NOT delete this final bracket that ends the Next() function:		
}	


			
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Hey man let's just try to calm down! Why don't I get both of us a drink huh?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = " ";
				Char3speech.text = " ";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Pleas! What would your wife think!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = " ";
				Char3speech.text = " ";
				
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know for sure, but I have to believe there is a way out of this.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = " ";
				Char3speech.text = " ";	
			
                primeInt = 39;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I saw it in the Bible! Jut trust me!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = " ";
				Char3speech.text = " ";	
				
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
		}
		
		
        public void SceneChange1(){ // rampage!
               SceneManager.LoadScene("End_Lose1_Farmer");
        }
        public void SceneChange2(){ // back to graveyard
                SceneManager.LoadScene("scene_2");
        }
		
		public void SceneChange3(){ // You win! All ghosts pacified
                SceneManager.LoadScene("End_Win");
        }
		
}