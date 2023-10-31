using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_9_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
	    public Text Char4name;
        public Text Char4speech;
        public Text Char5name;
        public Text Char5speech;
	   
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; // ghost accountant
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		
		public GameObject ArtChar2;  //bank worker 1
		public GameObject ArtChar3; // bank worker 2
		public GameObject ArtChar4a; // bank manager Jerry
		public GameObject ArtChar4b;
		
		
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button; // go to accountant family, scene_10
        public GameObject NextScene2Button; // bad ending: death by pens
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4a.SetActive(false);
		ArtChar4b.SetActive(false);
		
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false); // go to scene 10 (family of accountant)
        NextScene2Button.SetActive(false); // bad end
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
			Char1speech.text = "Ok. This bank looks normal enough.";
				Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
				
		}
		else if (primeInt == 3){
				Char1name.text = "YOU";
			Char1speech.text = "Oh. Wait. Now I hear the screaming.";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 4){
			ArtChar2.SetActive(true);
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "Bank Worker 1";
			Char3speech.text = "Run away! There's a ghost!";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 5){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(true);
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "Bank Worker 2";
			Char4speech.text = "AHH!!!";
				Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 6){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(false);
			ArtChar1c.SetActive(true);
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "You people don't deserve money if you don't even know how to handle it!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		
		else if (primeInt == 6){
			ArtChar1c.SetActive(false);
				Char1name.text = "YOU";
			Char1speech.text = "Craaaaaaaap. The boss is not gonna be happy about this.";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 7){
				Char1name.text = "YOU";
			Char1speech.text = "Woah- he's throwing things everywhere! This is dangerous!";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
       else if (primeInt == 8){
                Char1name.text = "YOU";
			Char1speech.text = "What do I do?";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): Please stop!
                Choice1b.SetActive(true); // function Choice1bFunct(): Ahh! Duck!
        }


       // after choice 1a (Of course!)
       	else if (primeInt == 20){
			ArtChar1c.SetActive(true);
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "Shut up kid. You can't handle your fiances, let alone me!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
	   
	    else if (primeInt == 21){
			ArtChar3.SetActive(true);
			ArtChar1c.SetActive(false);
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "Worker 2";
			Char4speech.text = "Ah! It's throwing pens!";
				Char5name.text = "";
			Char5speech.text = "";
		}
	   
		else if (primeInt == 22){
			ArtChar3.SetActive(false);
			ArtChar1c.SetActive(true);
			
				Char1name.text = "YOU";
			Char1speech.text = "Stop throwing pens! Ow! Ack- I better get behind a desk!";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
			primeInt = 29;
		}
		


       // after choice 1b
       	else if (primeInt == 30){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(false);
			ArtChar1c.SetActive(false);
			ArtChar4a.SetActive(true);
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "Bank Manager";
			Char5speech.text = " Hey over here!";
		}
	   
		else if (primeInt == 31){
				Char1name.text = "YOU";
			Char1speech.text = "Who are you?";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
	    else if (primeInt == 32){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "Bank Manager";
			Char5speech.text = "I am the bank manager. I can help you.";
		}
	   
		else if (primeInt == 33){
				Char1name.text = "YOU";
			Char1speech.text = "How? We can't fight him. He's too powerful!";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 34){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "Bank Manager";
			Char5speech.text = "He used to work at the bank. His family is still alive too!";
		}
	    else if (primeInt == 35){
			ArtChar2.SetActive(true);
			ArtChar3.SetActive(false);
			ArtChar1c.SetActive(false);
			ArtChar4a.SetActive(false);
			ArtChar4b.SetActive(false);
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "Bank Worker 1";
			Char3speech.text = "AHH!! Not my face! Anywhere but in my face!";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
	   
		else if (primeInt == 36){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(false);
			ArtChar1a.SetActive(true);
			ArtChar4a.SetActive(false);
			ArtChar4b.SetActive(false);
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = " Only good fiduciaries get to have faces!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
			//choice 2
			nextButton.SetActive(false);
			allowSpace = false;
			Choice2a.SetActive(true); // function Choice2aFunct():You must stop!
			Choice2b.SetActive(true); // function Choice2bFunct():What about your family?
		}	   
	 

// after choice 2a
       
	   	else if (primeInt == 40){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "What did you say kid?!! AHHH!!!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		
		else if (primeInt == 41){
				Char1name.text = "YOU";
			Char1speech.text = "I said you need to stop!";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		
		else if (primeInt == 42){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "Eat pens, wastrel!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
			//go to next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true); // you lose
			 }		
	

// after choice 2b
       	else if (primeInt == 50){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "My...family?";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
		 else if (primeInt == 51){
				Char1name.text = "YOU";
			Char1speech.text = "Yeah, this guy says they are still alive.";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}
	   	else if (primeInt == 52){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = " Is that… Jerry? Are you the manager now? You used to get me my coffee!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}	
		else if (primeInt == 53){
				Char1name.text = "YOU";
			Char1speech.text = " Would your family want you to rampage like this?";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}	
		else if (primeInt == 54){
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "You're right. If my children saw their father like this, what example would I be setting.";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
		}	
		else if (primeInt == 55){
			ArtChar4a.SetActive(true);
			ArtChar1b.SetActive(false);
			
			
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "";
			Char2speech.text = "";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "Bank Manager Jerry";
			Char5speech.text = "Here. I have written down their current address. Please leave.";
		}	
		else if (primeInt == 56){
			ArtChar4a.SetActive(false);
			ArtChar1b.SetActive(true);
				Char1name.text = "";
			Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
			Char2speech.text = "We fly, faster than an IRS audit!";
				Char3name.text = "";
			Char3speech.text = "";
				Char4name.text = "";
			Char4speech.text = "";
				Char5name.text = "";
			Char5speech.text = "";
			//go to next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // go to banker's family home
		}



		//END OF NEXT() function
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Please stop this. You're scaring everyone and destroying the bank!";
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
                Char1speech.text = "AH! Where can I hide??";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

//^^^ after you say that you move on to the good ending or the next ghost
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #2 and SceneChanges)
        public void Choice2aFunct(){
			ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hey! Ghost! Stop hurting people, you monster!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hey, Ghost! Stop it! What would your family think?!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

	public void SceneChange1(){
		SceneManager.LoadScene("scene_10");
	}
	
	public void SceneChange2(){
		SceneManager.LoadScene("End_Lose");
	}
	
	
	IEnumerator FadeIn(GameObject fadeImage, bool isBlack){
			int col = 1;
			if (isBlack){col=0;} else {col=1;} 
			
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage, bool isBlack){
			int col = 1;
			if (isBlack){col=0;} else {col=1;} 
				
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }
	
	
}
 
