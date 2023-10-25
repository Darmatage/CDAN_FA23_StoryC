using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_8_Dialogue1 : MonoBehaviour {
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
        public GameObject ArtChar1a; //happy
       public GameObject ArtChar1b; //about to die
       public GameObject ArtChar1c; //dead
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
		     ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "What the hell is this? Where did the people go? Who are these guys?...";
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
                Char1name.text = "YOU";
                Char1speech.text = "...Hey dude! Where are we?";
                Char2name.text = "";
                Char2speech.text = "";
				  Char3name.text = "";
                Char3speech.text = "";
				  Char4name.text = "";
                Char4speech.text = "";
				  Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...";
				  Char3name.text = "";
                Char3speech.text = "";
				  Char4name.text = "";
                Char4speech.text = "";
				  Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Must be a memory or something. He did say he would 'show me'";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "One day, thousands will die by Hector's hand...";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				 }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...and I-your greatest warrior-will do nothing ";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				 Char5name.text = "";
                Char5speech.text = "";
				 }
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "God he's even worse alive than dead";
                Char2name.text = "";
     	        Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
	 }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "You will beg for me to come back, but still I will do nothing...";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 11){
		     ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...The blood of those thousands rests at your feet.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know how much more I can take of this";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Audience memember 1";
                Char3speech.text = "Oh my god!";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "What? Oh shit he's not looking too good";
                Char2name.text = "";
                Char2speech.text = "";
				  Char3name.text = "";
                Char3speech.text = "";
				  Char4name.text = "";
                Char4speech.text = "";
				  Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Fear not! I am fine!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
					}
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "He is defintely not fine";
                Char2name.text = "";
                Char2speech.text = "";
				  Char3name.text = "";
                Char3speech.text = "";
				  Char4name.text = "";
                Char4speech.text = "";
				  Char5name.text = "";
                Char5speech.text = "";
					}
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Audience member 2";
                Char4speech.text = "Somone help him!";
				Char5name.text = "";
                Char5speech.text = "";
					}
       else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I can see a light. Do not mourn me...";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
					}
       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...My audience, for I am like a flower: beautiful, but short lived";
				  Char3name.text = "";
                Char3speech.text = "";
				  Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "What a fuckin dork";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 21){
		     ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I'm coming home, mother! *dies*";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Audiance member 1";
                Char3speech.text = "I can't believe what I'm seeing!";
				Char4name.text = "";
                Char4speech.text = "";
					Char5name.text = "";
                Char5speech.text = "";
				}
       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Audiance member 2";
                Char4speech.text = "I can't believe what I'm hearing!";
				Char5name.text = "";
                Char5speech.text = "";
					}
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "Audiance member 3";
                Char5speech.text = "What ever will we do?";
					}
   
       else if (primeInt == 25){
                Char1name.text = "YOU";
                Char1speech.text = "I can't belive these guys actually like him";
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
				NextScene1Button.SetActive(true);	 //back to scene_7
	   }
				
}
	
	
        public void SceneChange1(){//actor ghost rampage scene
               SceneManager.LoadScene("Scene_7");
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