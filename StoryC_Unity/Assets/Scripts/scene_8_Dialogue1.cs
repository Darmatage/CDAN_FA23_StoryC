using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_8_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //talking
       public GameObject ArtChar1b; //happy
       public GameObject ArtChar1c; //mad
        public GameObject ArtBG1;
		public GameObject BlackFade;
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
		GameHandler.metghost2 = true;
 
        DialogueDisplay.SetActive(false);
		ArtBG1.SetActive(true);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		BlackFade.SetActive(false);
		
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
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "What the hell is this? Where did the people go? Who are these guys?...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "...Hey dude! Where are we?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Must be a memory or something. He did say he would 'show me'";
                Char2name.text = "";
                Char2speech.text = "";
	 }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "One day, thousands will die by Hector's hand...";
				 }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...and I-your greatest warrior-will do nothing ";
				 }
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "God he's even worse alive than dead";
                Char2name.text = "";
     	        Char2speech.text = "";
	 }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "You will beg for me to come back, but still I will do nothing...";
				}
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...The blood of those thousands rests at your feet.";
				}
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know how much more I can take of this";
                Char2name.text = "";
                Char2speech.text = "";
				}
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Audience memember";
                Char2speech.text = "Oh my god!";
				}
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "What? Oh shit he's not looking too good";
                Char2name.text = "";
                Char2speech.text = "";
				}
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Fear not! I am fine!";
					}
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "He is defintely not fine";
                Char2name.text = "";
                Char2speech.text = "";
					}
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Audience member";
                Char2speech.text = "Somone help him!";
					}
       else if (primeInt == 18){
                Char1name.text = "Ghost Actor";
                Char1speech.text = "I can see a light. Do not morun me...";
                Char2name.text = "";
                Char2speech.text = "";
					}
       else if (primeInt == 19){
                Char1name.text = "Ghost Actor";
                Char1speech.text = "...My audience, for I am like a flower: beautiful, but short lived";
                Char2name.text = "";
                Char2speech.text = "";
				}
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What a fuckin dork";
				}
       else if (primeInt == 21){
                Char1name.text = "Ghost Actor";
                Char1speech.text = "I'm coming home, mother! *dies*";
                Char2name.text = "";
                Char2speech.text = "";
				}
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Audiance member 1";
                Char2speech.text = "I can't beleive what I'm seeing!";
				}
       else if (primeInt == 23){
                Char1name.text = "Audiance member 2";
                Char1speech.text = "I can't beleive what I'm seeing!";
                Char2name.text = "";
                Char2speech.text = "";
					}
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Audiance member 3";
                Char2speech.text = "What ever will we do?";
					}
   
       else if (primeInt == 25){
                Char1name.text = "YOU";
                Char1speech.text = "I can't belive these guys actually like him";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): "Why do you care so much about this place anyways?"
                Choice1b.SetActive(true); // function Choice1bFunct(): "Who cares if they are bad actors"
        }
		
		
		//after choice 1a:
		 else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What a fuckin dork";
		}
		
		
		
		
		
		
		
		//after choice 1b:
		 else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What a fuckin dork";
		}
		
		
		
		
		
		
		
		
		
		//after choice 2a:
		 else if (primeInt == 50){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What a fuckin dork";
		}
		
		
		
		
		
		
		
		
		//after choice 2b:
		 else if (primeInt == 60){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "What a fuckin dork";
		}
		
		
		
		
		//don;t delete the end of the Next function bracket:
	}
		
		
//choice functions:
		
		public void Choice1aFunct(){ //no
                Char1name.text = "YOU";
                Char1speech.text = "Yeah no, all I see was you being an absolute dork then croaking";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice1bFunct(){//I understand 
                Char1name.text = "YOU";
                Char1speech.text = "I kind of get it now";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		
        public void Choice2aFunct(){ //if we say truth
                Char1name.text = "YOU";
                Char1speech.text = "Oh yeah that's right! I remember of course!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice2bFunct(){//if we lie 
                Char1name.text = "YOU";
                Char1speech.text = "Dude what are you even talking about? You aren't making sense!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		

		

		
        public void SceneChange1(){//actor ghost rampage scene
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){//succeed in calming the ghost, go to graveyard
                SceneManager.LoadScene("Scene_2");
        }
		
		public void SceneChange3(){//all ghosts calm, End Win
                SceneManager.LoadScene("End_Win");
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